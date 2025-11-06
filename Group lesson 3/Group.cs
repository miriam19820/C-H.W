using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Group
{
    public class Group<TMember, TLeader> : IList<TMember>
    {
        public TMember this[int index]
        {
            get => Members[index];
            set => Members[index] = value;
        }
        public List<TMember> Members { get; set; } = new List<TMember>();
        public TLeader Groupleader { get; set; }
        public int MaxOfMames { get; set; }
        public int MinOfNames { get; set; }
        public DateTime Openime { get; set; }
        public int Count => Members.Count;
        public bool IsReadOnly => false;
        public void Add(TMember member)
        {
            if (member == null) throw new ArgumentNullException(nameof(member));
            if (Members.Count >= MaxOfMames)
                throw new InvalidOperationException($"Cannot add more than {MaxOfMames} members.");
            Members.Add(member);
        }
        public void Clear()
        {
            Members.Clear();
        }
        public bool Contains(TMember item)
        {
            return Members.Contains(item);
        }
        public void CopyTo(TMember[] array, int arrayIndex)
        {
            Members.CopyTo(array, arrayIndex);
        }
        public IEnumerator<TMember> GetEnumerator()
        {
            return Members.GetEnumerator();
        }
        public int IndexOf(TMember item)
        {
            return Members.IndexOf(item);
        }
        public void Insert(int index, TMember item)
        {
            Members.Insert(index, item);
        }
        public bool Remove(TMember item)
        {
            return Members.Remove(item);
        }
        public void RemoveAt(int index)
        {
            Members.RemoveAt(index);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Members.GetEnumerator();
        }
        public void PrintAllMembers()
        {
            if (Members == null || !Members.Any())
            {
                Console.WriteLine("No members in the group.");
                return;
            }
            foreach (var m in Members)
            {
                Console.WriteLine(m);
            }
        }
        public bool IsValidSize()
        {
            return Members.Count >= MinOfNames && Members.Count <= MaxOfMames;
        }
        public TMember GetMemberByIndex(int index)
        {
            if (index < 0 || index >= Members.Count)
                throw new IndexOutOfRangeException();
            return Members[index];
        }
        public TMember FindMember(Predicate<TMember> predicate)
        {
            return Members.Find(predicate);
        }
        public void SortMembers()
        {
            if (Members is List<Student> studentList)
            {
                studentList.Sort();
            }
        }
    }
}