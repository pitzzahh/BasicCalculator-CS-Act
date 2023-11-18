using System;
using System.Windows;
using CalculatorPrivateAssembly;


namespace BasicCalculator;

/// <summary>
/// Interaction logic for FrmBasicCalculator.xaml
/// </summary>
public partial class FrmBasicCalculator
{
    public FrmBasicCalculator()
    {
        InitializeComponent();
    }

    private void OnCompute(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrEmpty(FirstNumber.Text) || !Validator.IsNumber(FirstNumber.Text))
        {
            MessageBox.Show("Please enter a valid first number.", "Error", MessageBoxButton.OK,
                MessageBoxImage.Error);
            return;
        }

        if (string.IsNullOrEmpty(Operation.Text))
        {
            MessageBox.Show("Please select a valid operation.", "Error", MessageBoxButton.OK,
                MessageBoxImage.Error);
            return;
        }

        if (string.IsNullOrEmpty(SecondNumber.Text) || !Validator.IsNumber(SecondNumber.Text))
        {
            MessageBox.Show("Please enter a valid first number.", "Error", MessageBoxButton.OK,
                MessageBoxImage.Error);
            return;
        }

        try
        {
            var totalContent = BasicComputation.Compute(
                Converter.Parse(FirstNumber.Text),
                Converter.Parse(SecondNumber.Text),
                char.Parse(Operation.Text)
            );

            Total.Content = totalContent is decimal decimalResult && decimal.Truncate(decimalResult) == decimalResult
                ? decimalResult.ToString("#,0")
                : totalContent.ToString()!;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}