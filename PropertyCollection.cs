using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CodemaoVisitor
{
    public partial class PropertyCollection : Control
    {
        public PropertyCollection()
        {
            InitializeComponent();
        }

        public PropertyCollection(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}