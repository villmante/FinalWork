using NUnit.Framework;

namespace FinalWork.Test
{
    class BarboraTest : BaseTest
    {

        [Test]
        public static void Test1BarboraLogin()
        {
            _loginPage.NavigateToPage();
            _loginPage.SelectCity();
            _loginPage.Login();
        }

        [Test]
        public static void Test2ItemAddTest()
        {
            _homePage.NavigateToPage();
            _homePage.EmptyBascet();
            _homePage.AddItem();
            _homePage.AssertItemAdded();
        }

        [Test]
        public static void Test3ItemsAddSumsTest()
        {
            _homePage.NavigateToPage();
            _homePage.EmptyBascet();
            _homePage.Add3Items();
            _homePage.AssertItemsAddedCartSum();
        }

        [Test]
        public static void Test4CreateShopListTest()
        {
            _salePage.CreateList();
            _salePage.AssertNewList();
        }

        [Test]
        public static void Test5AddToListTest()
        {
            _salePage.AddItemToList();
            _salePage.AssertItemToList();
        }

        [Test]
        public static void Test6AErraseListTest()
        {
            _salePage.RemoveList();
            _salePage.AsserListErrased();
        }

    }
}



