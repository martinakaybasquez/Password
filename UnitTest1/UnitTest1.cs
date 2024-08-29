using Passwords2._0;

namespace UnitTest1;




public class UnitTest1
{
    public List<string> existingPasswords = new List<string>()
    {
        "mod", "admin", "h4CkErShIt", "pAsswOrd1", "h4CkErShIt"
    };
  
    
    [Theory]
    
    [InlineData("admin", true)]
    [InlineData("mod", true)]
    [InlineData("pAsswOrd1", true)]
    [InlineData("PrInglE5", true)]
    [InlineData("h4CkErShIt", true)]
    /*
    [InlineData("password", false)]
    [InlineData("B6mUOj1", false)]
    [InlineData("HEllo WOr1d", false)]
    [InlineData("ZXCV1", false)]*/
    
    public void AlainBigBrainEnergy(string x, bool expected)
    {
        bool actual = PasswordStealer.AddPassword(x, existingPasswords);
        Assert.Equal(expected, actual); // false, false
    }


    /*[Theory]
    [InlineData("hello", true)]
    [InlineData("alain", true)]
    public void CheckingIfMethodWorks(string x, bool expected)
    {
        // arrange
        PasswordStealer sut = new PasswordStealer();
        
        // act
        bool result = sut.HereIAm(x);

        // assert 
        Assert.Equal(expected, result);
    }*/
    
    
}