using System;
using System.ComponentModel;
using Xunit;
using Xunit.Sdk;

namespace Tester
{
    public class Tester
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
    

    [Fact]
    public void testvariable()
    {
    /*bool container = true;
     container = false;
            Assert.True(container);*/

    string name = "zara";
            /*if (false)
            {
                 name = "maro";
            }
                 Assert.Equal(expected:"zara", actual: name);
            */

            if (true)
            {
                name = "maro";
            }
            Assert.Equal(expected: "zara", actual: name);

    }

    [Fact]

    public void Test3()
    {
        string name;

        bool lever = true;
        
        if(lever)
        {
            name = "mina";
        }

        else
            name = "ziba";

        Assert.Equal(expected:"mina", actual: name);
    }

    [Fact]
    public void Test4()
    {

        Assert.Contains(string.Empty, "");
    }

    }
    
}


