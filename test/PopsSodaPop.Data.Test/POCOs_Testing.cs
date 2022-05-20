using System.Collections.Generic;
using Xunit;

namespace PopsSodaPop.Data;

public class UnitTest1
{
    [Fact]
    public void CreateAnInstanceOf_Employee()
    {
        Employee employee = new Employee("Peter", "Parker");
        employee.ID = 1;


        int expectedEmpID = 1;
        int actualEmpID = employee.ID;

        Assert.Equal(expectedEmpID, actualEmpID);
    }

    [Fact]
    public void CreateAnInstanceOf_Vendor()
    {
        // Arrange
        Vendor vendor = new Vendor("Coca-Cola");
        
        // Act
        string expected = "Coca-Cola";
        string actual = vendor.Name;

        // Assert
        Assert.Contains(expected, actual);
    }

    [Fact]
    public void CreateAnInstanceOf_Store()
    {
        // Arrange
        Store store = new Store();
        store.Employees = new List<Employee>
        {
            new Employee("Bruce", "Wayne")
        };

        // Act
        int expected = 1;
        int actual = store.Employees.Count;

        // Assert
        Assert.Equal(expected, actual);
    }
}