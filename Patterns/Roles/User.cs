using System;
using Patterns.Actions.Adding;
using Patterns.Actions.Removing;
using Patterns.Editing;

namespace Patterns.Roles
{
    public abstract class User
    {
        protected IAdding Adding;
        protected IEditing Editing;
        protected IRemoving Removing;

        protected User()
        {
            Adding = new NoAdd();
            Editing = new NoEdit();
            Removing = new NoRemove();
        }

        public void Read()
        {
            Console.WriteLine("I can read.");
        }

        public void Add()
        {
            Adding.Adding();
        }

        public void Edit()
        {
            Editing.Editing();
        }

        public void Remove()
        {
            Removing.Removing();
        }

        public abstract void WhoIs();
    }
}
