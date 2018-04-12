using GradeBook.Mobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.Mobile.Data
{
    public class Repository
    {
        private ICollection<IPerson> items;

        public Repository()
        {
            this.items = new List<string>();
        }

        public void AddItem(string item)
        {
            this.items.Add(item);
        }

        public bool DeleteItem(string item)
        {
            if (this.items.Contains(item))
            {
                return this.items.Remove(item);
            }
            return false;
        }

        public ICollection<string> GetAll()
        {
            return this.items;
        }
    }
}
