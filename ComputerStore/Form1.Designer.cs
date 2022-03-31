
namespace ComputerStore
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.buttonCatalogs = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(276, 73);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(165, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Компьютерный магазин";
            // 
            // buttonCatalogs
            // 
            this.buttonCatalogs.AutoSize = true;
            this.buttonCatalogs.Location = new System.Drawing.Point(291, 108);
            this.buttonCatalogs.Name = "buttonCatalogs";
            this.buttonCatalogs.Size = new System.Drawing.Size(134, 27);
            this.buttonCatalogs.TabIndex = 1;
            this.buttonCatalogs.Text = "Товарные группы";
            this.buttonCatalogs.UseVisualStyleBackColor = true;
            // 
            // buttonProducts
            // 
            this.buttonProducts.AutoSize = true;
            this.buttonProducts.Location = new System.Drawing.Point(291, 155);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(134, 27);
            this.buttonProducts.TabIndex = 2;
            this.buttonProducts.Text = "Товары";
            this.buttonProducts.UseVisualStyleBackColor = true;
            // 
            // buttonOrders
            // 
            this.buttonOrders.AutoSize = true;
            this.buttonOrders.Location = new System.Drawing.Point(291, 205);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(134, 27);
            this.buttonOrders.TabIndex = 3;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = true;
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.AutoSize = true;
            this.buttonCustomers.Location = new System.Drawing.Point(291, 256);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(134, 27);
            this.buttonCustomers.TabIndex = 4;
            this.buttonCustomers.Text = "Покупатели";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCustomers);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonCatalogs);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCatalogs;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonCustomers;
    }
}

