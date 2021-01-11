using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcodecsharp.DataStructure
{
    public class PriorityQueue<T> where T : IComparable, IComparable<T>
    {
        private SortedSet<T> values;

        /// <summary>
        /// Default constructor
        /// </summary>
        public PriorityQueue()
        {
            values = new SortedSet<T>();
        }

        /// <summary>
        /// Constructor with an IEnumerble parameter
        /// </summary>
        /// <param name="elements"></param>
        public PriorityQueue(IEnumerable<T> elements)
        {
            values = new SortedSet<T>(elements);
        }

        /// <summary>
        /// Constructor with a customed comparer and IEnumerable parameters
        /// </summary>
        /// <param name="comparer"></param>
        /// <param name="elements"></param>
        public PriorityQueue(IComparer<T> comparer, IEnumerable<T> elements)
        {
            values = new SortedSet<T>(elements, comparer);
        }

        /// <summary>
        /// Gets the number of elements in the PriorityQueue.
        /// </summary>
        public int Count => values.Count;

        /// <summary>
        /// Returns the top element in the PriorityQueue.
        /// </summary>
        /// <returns></returns>
        public T Top() => values.Max;

        /// <summary>
        /// Remove the element on top of the PriorityQueue.
        /// </summary>
        public bool Pop() => values.Remove(values.Max);

        /// <summary>
        /// Inserts a new element to the PriorityQueue.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>true if successfully, false otherwise</returns>
        public bool Push(T value) => values.Add(value);

        /// <summary>
        /// Returns whether the queue is empty.
        /// </summary>
        /// <returns>true if the queue's size is 0, faslse otherwise</returns>
        public bool IsEmpty() => !values.Any();

        /// <summary>
        /// Returns a List from a priority queue.
        /// </summary>
        /// <returns></returns>
        public List<T> ToList() => values.ToList();

    }
}
