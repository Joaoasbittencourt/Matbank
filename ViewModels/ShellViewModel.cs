using Caliburn.Micro;
using Matbank.Models;
using System;
using System.Collections.Generic;

namespace Matbank.ViewModels
{
    public class ShellViewModel: Conductor<IScreen>
    {
        public ShellViewModel()
        {
            // Dummy data
            Items.Add(new ItemModel { Name = "Cimento 50kg", Description = "Cimento ensacado para entrega" });
            Items.Add(new ItemModel { Name = "Barra de Ferro 16mm", Description = "D = 16mm, 12m" });
            Items.Add(new ItemModel { Name = "Parafuso A36 - 10mm", Description = "Aço: A36, D =  10mm" });
        }

        public bool CanAddItem
        {
            get { return !string.IsNullOrEmpty(ItemName); }
        }

        public bool CanDeleteItem
        {
            get { return Items.Contains(SelectedItem); }
        }

        private string _itemName;
        public string ItemName
        {
            get { return _itemName; }
            set
            {
                _itemName = value;
                NotifyOfPropertyChange(() => ItemName);
                NotifyOfPropertyChange(() => CanAddItem);
            }
        }

        private string _itemDescription;
        public string ItemDescription
        {
            get { return _itemDescription; }
            set
            {
                _itemDescription = value;
                NotifyOfPropertyChange(() => ItemDescription);
            }
        }

        private BindableCollection<ItemModel> _items = new BindableCollection<ItemModel>();
        public BindableCollection<ItemModel> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                NotifyOfPropertyChange(() => CanDeleteItem);
            }
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

        public void AddItem()
        {
            Items.Add(new ItemModel { Name = ItemName, Description = ItemDescription });
            ItemName = "";
            ItemDescription = "";
        }

        public void RemoveItem()
        {
            Items.Remove(SelectedItem);
        }
    }
}
