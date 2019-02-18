using Caliburn.Micro;
using Matbank.Models;
using System.Collections.Generic;

namespace Matbank.ViewModels
{
    public class ShellViewModel: Screen
    {

        public ShellViewModel()
        {
            Items.Add(new ItemModel {  });
        }

        private string _itemName;
        public string ItemName
        {
            get { return _itemName; }
            set
            {
                _itemName = value;
                NotifyOfPropertyChange(() => ItemName);
            }
        }

        private BindableCollection<ItemModel> _items = new BindableCollection<ItemModel>();
        public BindableCollection<ItemModel> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        private ItemModel _selectedItem;

        public ItemModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                NotifyOfPropertyChange(() => SelectedItem);
            }
        }

    }
}
