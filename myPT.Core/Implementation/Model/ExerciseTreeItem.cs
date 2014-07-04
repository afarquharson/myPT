using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Implementation.Model
{
    [Serializable]
    public class ExerciseTreeItem
    {
        private Dictionary<string, IExercise> _exercises;
        public Dictionary<string, IExercise> Exercises 
        { 
            get { return _exercises; } 
            set 
            { 
                if (Children != null && Children.Count() > 0) 
                { 
                    throw new Exception("Cannot add exercises to a set with children."); 
                } 
                else 
                { 
                    _exercises = value; 
                } 
            } 
        }
        public int Reps { get; set; }
        private List<ExerciseTreeItem> _children;
        public List<ExerciseTreeItem> Children 
        {
            get { return _children; }
            set
            {
                if (Exercises != null && Exercises.Count > 0)
                {
                    throw new Exception("Cannot add child sets to a set with exercises.");
                }
                else
                {
                    _children = value;
                }
            }
        }

        public ExerciseTreeItem()
        {
            Exercises = new Dictionary<string, IExercise>();
            Children = new List<ExerciseTreeItem>();
        }

        public IExercise FindExercise(string GUID)
        {
            return Find(this, GUID).Exercises[GUID];
        }

        private static ExerciseTreeItem Find(ExerciseTreeItem node, string GUID)
        {
            /*
             *  http://stackoverflow.com/questions/6556170/recursively-search-nested-lists
             */
            if (node == null) return null;
            if (node.Exercises.ContainsKey(GUID)) return node;

            foreach (var child in node.Children)
            {
                var found = Find(child, GUID);
                if (found != null) return found;
            }
            return null;
        }

        public List<IExercise> Flatten()
        {
            return Flatten(this);
        }

        private static List<IExercise> Flatten(ExerciseTreeItem node)
        {
            var thisLevel = new List<IExercise>();
            if (node.Children.Count > 0)
            {
                //If there are children, add them all for each rep
                for (var i = 0; i < node.Reps; i++)
                {
                    foreach (var child in node.Children)
                    {
                        thisLevel.AddRange(Flatten(child));
                    }
                }
            }
            else
            {
                for (var i = 0; i < node.Reps; i++) //If there are no children, add the exercises at this level for each rep
                {
                    thisLevel.AddRange(node.Exercises.Values.ToList());
                }
            }
            return thisLevel;
        }

        internal List<KeyValuePair<string, string>> PrintTree()
        {
            return Print(this, string.Empty);
        }

        private static List<KeyValuePair<string, string>> Print(ExerciseTreeItem node, string prefix)
        {
            var thisLevel = new List<KeyValuePair<string, string>>();
            if (node.Reps > 0) thisLevel.Add(new KeyValuePair<string, string>(String.Empty, String.Format("{0}x{1}", prefix, node.Reps.ToString())));
            if (node.Children.Count > 0)
            {
                //If there are children, update the prefix and traverse
                foreach(var child in node.Children)
                {
                    thisLevel.AddRange(Print(child, String.Format(" {0}",prefix))); 
                }
            }
            else
            {
                //If there are no children, add each exercise description and reps
                foreach (var e in node.Exercises)
                {
                    thisLevel.Add(new KeyValuePair<string, string>(e.Key, String.Format("{0}{1} x{2}", prefix, e.Value.Detail[Common.ExerciseFieldKey.Description], e.Value.Detail[Common.ExerciseFieldKey.MaxReps])));
                }
            }
            if (node.Reps > 0) thisLevel.Add(new KeyValuePair<string,string>(String.Empty, prefix));
            return thisLevel;
        }

        public override bool Equals(object obj)
        {
            var other = (ExerciseTreeItem)obj;
            if (other == null)
            {
                return false;
            }
            else
            {
                return this.Reps == other.Reps && this.Exercises.SequenceEqual(other.Exercises) && Children.SequenceEqual(other.Children);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
