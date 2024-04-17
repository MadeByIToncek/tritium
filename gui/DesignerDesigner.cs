namespace Tritium.gui
{
    internal class DesignerDesigner
    {

        public readonly TableLayoutPanel subLayout;
        public Button? recycle;
        public Button? plus;
        public Button? minus;
        public Label? index;

        public DesignerDesigner() {
            subLayout = GenerateSubLayout();
        }

        public TableLayoutPanel GenerateSubLayout()
        {   
            TableLayoutPanel subLayout = new TableLayoutPanel();
            // 
            // subLayout
            // 
            subLayout.ColumnCount = 2;
            subLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11F));
            subLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89F));
            subLayout.Controls.Add(GenerateAPanel(), 0, 0);
            //subLayout.Controls.Add(GenerateBPanel(), 1, 0);
            subLayout.Dock = DockStyle.Fill;
            subLayout.Location = new Point(4, 4);
            subLayout.Name = "subLayout";
            subLayout.RowCount = 1;
            subLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            subLayout.Size = new Size(1334, 594);
            subLayout.TabIndex = 0;

            return subLayout;
        }

        private Control GenerateBPanel()
        {
            throw new NotImplementedException();
        }

        private TableLayoutPanel GenerateAPanel()
        {
            TableLayoutPanel subLayoutAController = new();
            // 
            // subLayoutAController
            // 
            subLayoutAController.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            subLayoutAController.ColumnCount = 1;
            subLayoutAController.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            subLayoutAController.Controls.Add(GenerateRecycleButton(), 0, 3);
            subLayoutAController.Controls.Add(GenerateIndexController(), 0, 0);
            //subLayoutAController.Controls.Add(tableLayoutPanel6, 0, 1);
            subLayoutAController.Dock = DockStyle.Fill;
            subLayoutAController.Location = new Point(3, 3);
            subLayoutAController.Name = "subLayoutAController";
            subLayoutAController.RowCount = 4;
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            subLayoutAController.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            subLayoutAController.Size = new Size(140, 588);
            subLayoutAController.TabIndex = 0;

            return subLayoutAController;
        }

        private TableLayoutPanel GenerateIndexController()
        {
            TableLayoutPanel indexController = new TableLayoutPanel();
            indexController.ColumnCount = 1;
            indexController.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            indexController.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            indexController.Controls.Add(GenerateIndex(), 0, 0);
            indexController.Controls.Add(GenerateIndexPlusMinus(), 0, 1);
            indexController.Dock = DockStyle.Fill;
            indexController.Location = new Point(4, 4);
            indexController.Name = "indexController";
            indexController.RowCount = 2;
            indexController.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            indexController.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            indexController.Size = new Size(132, 188);
            indexController.TabIndex = 4;
            return indexController;
        }

        private TableLayoutPanel GenerateIndexPlusMinus()
        {
            TableLayoutPanel indexPlusMinus = new TableLayoutPanel();
            plus = new Button();
            minus = new Button();
            // 
            // indexPlusMinus
            // 
            indexPlusMinus.ColumnCount = 2;
            indexPlusMinus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            indexPlusMinus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            indexPlusMinus.Controls.Add(plus, 1, 0);
            indexPlusMinus.Controls.Add(minus, 0, 0);
            indexPlusMinus.Dock = DockStyle.Fill;
            indexPlusMinus.Location = new Point(3, 97);
            indexPlusMinus.Name = "indexPlusMinus";
            indexPlusMinus.RowCount = 1;
            indexPlusMinus.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            indexPlusMinus.Size = new Size(126, 88);
            indexPlusMinus.TabIndex = 1;
            // 
            // plus
            // 
            plus.Dock = DockStyle.Fill;
            plus.Location = new Point(66, 3);
            plus.Name = "plus";
            plus.Size = new Size(57, 82);
            plus.TabIndex = 1;
            plus.Text = "➕";
            plus.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            minus.Dock = DockStyle.Fill;
            minus.Location = new Point(3, 3);
            minus.Name = "minus";
            minus.Size = new Size(57, 82);
            minus.TabIndex = 0;
            minus.Text = "➖";
            minus.UseVisualStyleBackColor = true;

            return indexPlusMinus;
        }

        private Label GenerateIndex()
        {
            Label index = new Label();
            index.Dock = DockStyle.Fill;
            index.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            index.Location = new Point(3, 0);
            index.Name = "poradi";
            index.Size = new Size(126, 94);
            index.TabIndex = 0;
            index.Text = "#10";
            index.TextAlign = ContentAlignment.MiddleCenter;
            this.index = index;
            return index;
        }

        private Button GenerateRecycleButton()
        {
            Button recycle = new Button();
            recycle.Dock = DockStyle.Fill;
            recycle.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recycle.ForeColor = Color.ForestGreen;
            recycle.Location = new Point(4, 394);
            recycle.Name = "recycle";
            recycle.Size = new Size(132, 190);
            recycle.TabIndex = 1;
            recycle.Text = "♻";
            recycle.UseVisualStyleBackColor = true;
            this.recycle = recycle;
            return recycle;
        }
    }
}