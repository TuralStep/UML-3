namespace HW_1;

public interface Button
{
    void Render();
    void OnClick();
}

public class WindowsButton : Button
{
    public void OnClick() =>
        Console.WriteLine("WindowsButton clicked...");

    public void Render() =>
        Console.WriteLine("WindowsButton rendered...");
}
public class HTMLButton : Button
{
    public void OnClick() =>
        Console.WriteLine("HTMLButton clicked...");

    public void Render() =>
        Console.WriteLine("HTMLButton rendered...");
}



public abstract class Dialog
{
    public void Render()
    {
        Button okButton = CreateButton();
        okButton.OnClick();
        okButton.Render();
    }

    public abstract Button CreateButton();
}

public class WindowsDialog : Dialog
{
    public override Button CreateButton() =>
        new WindowsButton();
}
public class WebDialog : Dialog
{
    public override Button CreateButton() =>
        new HTMLButton();
}