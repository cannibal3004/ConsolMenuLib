using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleMenuLib
{
    public class ConsoleMenu
    {
        private List<ConsoleMenuItem> _MenuItems;
        public ConsoleMenu PreviousMenu { get; private set; }

        public ConsoleMenuItem SelectedItem
        {
            get
            {
                return (from ConsoleMenuItem item in _MenuItems
                    where item.Selected
                    select item).Single();
            }
        }

        public void SelectIndex(int index)
        {
            
        }

        private void DeSelectAll()
        {
            foreach (ConsoleMenuItem consoleMenuItem in _MenuItems)
            {
                consoleMenuItem.DeSelect();
            }
        }
    }

    public class ConsoleMenuItem
    {
        
        public MenuItemType Type { get; private set; }
        public string Text { get; private set; }
        public bool Selected { get; private set; }

        public void Select()
        {
            Selected = true;
        }

        public void DeSelect()
        {
            Selected = false;
        }
        
    }

    public enum MenuItemType
    {
        Selectable,
        SubMenu
    }
}
