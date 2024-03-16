using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public delegate string StringGetter<T>(T obj);
public delegate void OnLoad();

namespace CodemaoVisitor
{
    public partial class GenerateConfigForm : Form
    {
        private OnLoad load;
        
        public event OnLoad LoadEvent
        {
            add
            {
                load += value;
            }
            remove
            {
                load -= value;
            }
        }
        
        public GenerateConfigForm()
        {
            InitializeComponent();
        }

        private void GenerateConfig_Load(object sender, EventArgs e)
        {
            System.Drawing.Font font = new System.Drawing.Font("Microsoft YaHei", 9.5f, 
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ((byte)(134)));
            var col0 = new DataGridViewTextBoxColumn();
            col0.HeaderText = "键";
            col0.Width = 400;
            col0.DefaultCellStyle.BackColor = Color.Gray;
            col0.ReadOnly = true;
            col0.DefaultCellStyle.Font = font;
            col0.HeaderCell.Style.Font = font;
            dgvProperties.Columns.Add(col0);
            var col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "字符串值或字典键";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col1.DefaultCellStyle.Font = font;
            col1.HeaderCell.Style.Font = font;
            dgvProperties.Columns.Add(col1);
            dgvProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvProperties.ColumnHeadersHeight = 40;
            dgvProperties.RowTemplate.Height = 45;
            load?.Invoke();
            dgvProperties.ClearSelection();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Button ConfirmButton => btnConfirm;

        public List<string> GetConfigs()
        {
            var res = new List<string>();
            foreach (DataGridViewRow row in dgvProperties.Rows)
            {
                res.Add(row.Cells[1].Value.ToString());
            }
            return res;
        }
        
        public void AddRows<T>(IEnumerable<T> keys, StringGetter<T> getter)
        {
            foreach (var key in keys)
            {
                dgvProperties.Rows.Add(key, "");
            }
        }
    }
}