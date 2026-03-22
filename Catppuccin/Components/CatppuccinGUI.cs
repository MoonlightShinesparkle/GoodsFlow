using System.ComponentModel;
using System.Windows.Forms;

namespace GoodsFlow.Catppuccin.Components;

public class CatppuccinButton : Button, ICatppuccinEnabled
{
    public CatppuccinButton() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Surface0;
    private CatppuccinColor FCC = CatppuccinColor.Sapphire;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor {
        get => BCC; set {
            BCC = value;
            ApplyCatppuccin();
        } 
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor {
        get => FCC; set { 
            FCC = value; 
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}

public class CatppuccinForm : Form, ICatppuccinEnabled
{
    public CatppuccinForm() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Crust;
    private CatppuccinColor FCC = CatppuccinColor.Sapphire;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor
    {
        get => BCC; set
        {
            BCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor
    {
        get => FCC; set
        {
            FCC = value;
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}

public class CatppuccinPanel : Panel, ICatppuccinEnabled
{
    public CatppuccinPanel() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Mantle;
    private CatppuccinColor FCC = CatppuccinColor.Transparent;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor
    {
        get => BCC; set
        {
            BCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor
    {
        get => FCC; set
        {
            FCC = value;
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}

public class CatppuccinTextBox : TextBox, ICatppuccinEnabled
{
    public CatppuccinTextBox() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Surface0;
    private CatppuccinColor FCC = CatppuccinColor.Green;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor
    {
        get => BCC; set
        {
            BCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor
    {
        get => FCC; set
        {
            FCC = value;
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}

public class CatppuccinMaskedTextBox : MaskedTextBox, ICatppuccinEnabled
{
    public CatppuccinMaskedTextBox() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Surface0;
    private CatppuccinColor FCC = CatppuccinColor.Mauve;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor
    {
        get => BCC; set
        {
            BCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor
    {
        get => FCC; set
        {
            FCC = value;
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}

public class CatppuccinCheckBox : CheckBox, ICatppuccinEnabled
{
    public CatppuccinCheckBox() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Transparent;
    private CatppuccinColor FCC = CatppuccinColor.Peach;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor
    {
        get => BCC; set
        {
            BCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor
    {
        get => FCC; set
        {
            FCC = value;
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}

public class CatppuccinRadioButton : RadioButton, ICatppuccinEnabled
{
    public CatppuccinRadioButton() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Transparent;
    private CatppuccinColor FCC = CatppuccinColor.Rosewater;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor
    {
        get => BCC; set
        {
            BCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor
    {
        get => FCC; set
        {
            FCC = value;
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}

public class CatppuccinTabControl : TabControl, ICatppuccinEnabled
{
    public CatppuccinTabControl() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Mantle;
    private CatppuccinColor FCC = CatppuccinColor.Flamingo;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor
    {
        get => BCC; set
        {
            BCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor
    {
        get => FCC; set
        {
            FCC = value;
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}

public class CatppuccinLabel : Label, ICatppuccinEnabled
{
    public CatppuccinLabel() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Transparent;
    private CatppuccinColor FCC = CatppuccinColor.Text;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor
    {
        get => BCC; set
        {
            BCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor
    {
        get => FCC; set
        {
            FCC = value;
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}

public class CatppuccinListBox : ListBox, ICatppuccinEnabled
{
    public CatppuccinListBox() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Surface0;
    private CatppuccinColor FCC = CatppuccinColor.Lavender;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor
    {
        get => BCC; set
        {
            BCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor
    {
        get => FCC; set
        {
            FCC = value;
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}

public class CatppuccinCheckedListBox : CheckedListBox, ICatppuccinEnabled
{
    public CatppuccinCheckedListBox() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Surface0;
    private CatppuccinColor FCC = CatppuccinColor.Sky;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor
    {
        get => BCC; set
        {
            BCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor
    {
        get => FCC; set
        {
            FCC = value;
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}

public class CatppuccinNumericUpDown : NumericUpDown, ICatppuccinEnabled
{
    public CatppuccinNumericUpDown() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Surface0;
    private CatppuccinColor FCC = CatppuccinColor.Green;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor
    {
        get => BCC; set
        {
            BCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor
    {
        get => FCC; set
        {
            FCC = value;
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}

public class CatppuccinDomainUpDown : DomainUpDown, ICatppuccinEnabled
{
    public CatppuccinDomainUpDown() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Surface0;
    private CatppuccinColor FCC = CatppuccinColor.Red;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor
    {
        get => BCC; set
        {
            BCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor
    {
        get => FCC; set
        {
            FCC = value;
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}

public class CatppuccinDataGridView : DataGridView // Technically doesn't fit the ICatppuccinEnabled structure
{
    public CatppuccinDataGridView() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Mantle;
    private CatppuccinColor FCC = CatppuccinColor.Sky;
    private CatppuccinColor GCC = CatppuccinColor.Crust;
    private CatppuccinColor TBCC = CatppuccinColor.Surface0;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor CBackgroundColor
    {
        get => BCC; set
        {
            BCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor
    {
        get => FCC; set
        {
            FCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor CGridColor
    {
        get => GCC; set
        {
            GCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor DataBackgroundColor
    {
        get => TBCC; set
        {
            TBCC = value;
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(CBackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
        GridColor = CatppuccinPallette.GetColor(CGridColor);
        BackgroundColor = CatppuccinPallette.GetColor(DataBackgroundColor);
    }
}

public class CatppuccinComboBox : ComboBox, ICatppuccinEnabled
{
    public CatppuccinComboBox() : base()
    {
        ApplyCatppuccin();
    }

    private CatppuccinColor BCC = CatppuccinColor.Surface0;
    private CatppuccinColor FCC = CatppuccinColor.Maroon;
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor BackgroundColor
    {
        get => BCC; set
        {
            BCC = value;
            ApplyCatppuccin();
        }
    }
    [Category("Catppuccin")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public CatppuccinColor ForegroundColor
    {
        get => FCC; set
        {
            FCC = value;
            ApplyCatppuccin();
        }
    }

    public void ApplyCatppuccin()
    {
        BackColor = CatppuccinPallette.GetColor(BackgroundColor);
        ForeColor = CatppuccinPallette.GetColor(ForegroundColor);
    }
}