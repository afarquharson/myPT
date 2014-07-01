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
                if (Children.Count() > 0) 
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
                if (Exercises.Count > 0)
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

        public ExerciseTreeItem FindExercise(string GUID)
        {
            return Find(this, GUID);
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

        public Dictionary<string, IExercise> Flatten()
        {
            return Flatten(this);
        }

        private static Dictionary<string, IExercise> Flatten(ExerciseTreeItem node)
        {
            var thisLevel = new Dictionary<string, IExercise>();
            if (node.Children.Count > 0)
            {
                //If there are children, add them all for each rep
                for (var i = 0; i < node.Reps; i++)
                {
                    foreach (var child in node.Children)
                    {
                        thisLevel.Concat(Flatten(child));
                    }
                }
                return thisLevel;
            }
            else
            {
                for (var i = 0; i < node.Reps; i++) //If there are no children, add the exercises at this level for each rep
                {
                    thisLevel.Concat(node.Exercises);
                }
                return thisLevel;
            }
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
