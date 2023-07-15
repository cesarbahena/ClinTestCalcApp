namespace ClinTestCalc;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        firstInputLabel = new Label();
        firstParameter = new TextBox();
        clinicalTest1 = new RadioButton();
        clinicalTest2 = new RadioButton();
        clinicalTestSelectorLabel = new Label();
        secondParameterLabel = new Label();
        secondParameter = new TextBox();
        SuspendLayout();
        // 
        // firstInputLabel
        // 
        firstInputLabel.AutoSize = true;
        firstInputLabel.Location = new Point(5, 90);
        firstInputLabel.Name = "firstInputLabel";
        firstInputLabel.Size = new Size(92, 15);
        firstInputLabel.TabIndex = 0;
        firstInputLabel.Text = "Select a test first";
        // 
        // firstParameter
        // 
        firstParameter.Location = new Point(103, 87);
        firstParameter.Name = "firstParameter";
        firstParameter.Size = new Size(100, 23);
        firstParameter.TabIndex = 1;
        // 
        // clinicalTest1
        // 
        clinicalTest1.AutoSize = true;
        clinicalTest1.Location = new Point(12, 23);
        clinicalTest1.Name = "clinicalTest1";
        clinicalTest1.Size = new Size(125, 19);
        clinicalTest1.TabIndex = 2;
        clinicalTest1.TabStop = true;
        clinicalTest1.Text = "Yodo proteico / ITL";
        clinicalTest1.UseVisualStyleBackColor = true;
        // 
        // clinicalTest2
        // 
        clinicalTest2.AutoSize = true;
        clinicalTest2.Location = new Point(12, 48);
        clinicalTest2.Name = "clinicalTest2";
        clinicalTest2.Size = new Size(86, 19);
        clinicalTest2.TabIndex = 3;
        clinicalTest2.TabStop = true;
        clinicalTest2.Text = "IRI (HOMA)";
        clinicalTest2.UseVisualStyleBackColor = true;
        // 
        // clinicalTestSelectorLabel
        // 
        clinicalTestSelectorLabel.AutoSize = true;
        clinicalTestSelectorLabel.Location = new Point(5, 5);
        clinicalTestSelectorLabel.Name = "clinicalTestSelectorLabel";
        clinicalTestSelectorLabel.Size = new Size(69, 15);
        clinicalTestSelectorLabel.TabIndex = 4;
        clinicalTestSelectorLabel.Text = "Select a test";
        // 
        // secondParameterLabel
        // 
        secondParameterLabel.AutoSize = true;
        secondParameterLabel.Enabled = false;
        secondParameterLabel.Location = new Point(5, 119);
        secondParameterLabel.Name = "secondParameterLabel";
        secondParameterLabel.Size = new Size(92, 15);
        secondParameterLabel.TabIndex = 0;
        secondParameterLabel.Text = "Select a test first";
        // 
        // secondParameter
        // 
        secondParameter.Enabled = false;
        secondParameter.Location = new Point(103, 116);
        secondParameter.Name = "secondParameter";
        secondParameter.Size = new Size(100, 23);
        secondParameter.TabIndex = 1;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(316, 342);
        Controls.Add(clinicalTestSelectorLabel);
        Controls.Add(clinicalTest2);
        Controls.Add(clinicalTest1);
        Controls.Add(secondParameter);
        Controls.Add(secondParameterLabel);
        Controls.Add(firstParameter);
        Controls.Add(firstInputLabel);
        Name = "MainForm";
        Text = "Calculadora de exámenes clínicos";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label firstInputLabel;
    private TextBox firstParameter;
    private RadioButton clinicalTest1;
    private RadioButton clinicalTest2;
    private Label clinicalTestSelectorLabel;
    private Label secondParameterLabel;
    private TextBox secondParameter;
}