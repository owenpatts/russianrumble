using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russianrumble
{
    class Storage
    {
        private int scrollpos = 0;
        ArrayList inventory;

        public Storage()
        {

        }

        public void Store(Item item)
        {
            inventory.Add(item);
        }

        public Item Take(int idx)
        {
            Item removed = (Item) inventory[idx];
            inventory.Remove(idx);
            return removed;
        }

        public ArrayList Display()
        {
            ArrayList displayedItems = new ArrayList;
            for(int i = scrollpos; i < inventory.Count; i++)
            {
                displayedItems.Add(inventory[i]);
            }
            return displayedItems;
        }

        public void ScrollUp()
        {
            if(scrollpos > 0)
            {
                scrollpos--;
            }
        }
        
        public void ScrollDown()
        {
            if (scrollpos < inventory.Count - 5)
            {
                scrollpos++;
            }
        }
    }
}
