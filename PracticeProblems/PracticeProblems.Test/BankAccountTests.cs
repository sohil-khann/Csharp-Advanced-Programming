namespace PracticeProblems.Test;
using PracticeProblems.App;

public class BankAccountTests
{
    [Test]
    public void Deposit_ValidAmount_IncreasesBalance()
    {
        // Arrange
        var account = new BankAccount(100);

        // Act
        account.Deposit(50);

        // Assert
        Assert.That(account.GetBalance(), Is.EqualTo(150));
    }

    [Test]
    public void Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        var account = new BankAccount(100);

        // Act
        account.Withdraw(30);

        // Assert
        Assert.That(account.GetBalance(), Is.EqualTo(70));
    }

    [Test]
    public void Withdraw_InsufficientFunds_ThrowsException()
    {
        // Arrange
        var account = new BankAccount(100);

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => account.Withdraw(150));
    }
}
