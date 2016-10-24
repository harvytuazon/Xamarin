using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BPAAS_AutoApp.Models
{
    public class TreeModel
    {
        public string Name { get; set; }
        public bool Checked { get; set; }
        public ObservableCollection<SubTreeModel> Items { get; set; }
    }

    public class SubTreeModel
    {
        public string Title { get; set; }
        public bool Checked { get; set; }
    }
}
