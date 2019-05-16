using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StoredProcAndFunctionUnitTest
{
    [TestClass()]
    public class SqlServerUnitTest1 : SqlDatabaseTestClass
    {

        public SqlServerUnitTest1()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction CalculateCorrectSalaryTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTest1));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction UpdateSalaryInformationTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CalculateCorrectSalaryTest;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition UpdateSalaryInformationTest;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction UpdateSalaryInformationTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero;
            this.CalculateCorrectSalaryTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.UpdateSalaryInformationTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZeroData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            CalculateCorrectSalaryTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            UpdateSalaryInformationTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            CalculateCorrectSalaryTest = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            UpdateSalaryInformationTest = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            UpdateSalaryInformationTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // CalculateCorrectSalaryTest_TestAction
            // 
            CalculateCorrectSalaryTest_TestAction.Conditions.Add(CalculateCorrectSalaryTest);
            resources.ApplyResources(CalculateCorrectSalaryTest_TestAction, "CalculateCorrectSalaryTest_TestAction");
            // 
            // UpdateSalaryInformationTest_TestAction
            // 
            UpdateSalaryInformationTest_TestAction.Conditions.Add(UpdateSalaryInformationTest);
            resources.ApplyResources(UpdateSalaryInformationTest_TestAction, "UpdateSalaryInformationTest_TestAction");
            // 
            // CalculateCorrectSalaryTestData
            // 
            this.CalculateCorrectSalaryTestData.PosttestAction = null;
            this.CalculateCorrectSalaryTestData.PretestAction = null;
            this.CalculateCorrectSalaryTestData.TestAction = CalculateCorrectSalaryTest_TestAction;
            // 
            // UpdateSalaryInformationTestData
            // 
            this.UpdateSalaryInformationTestData.PosttestAction = null;
            this.UpdateSalaryInformationTestData.PretestAction = UpdateSalaryInformationTest_PretestAction;
            this.UpdateSalaryInformationTestData.TestAction = UpdateSalaryInformationTest_TestAction;
            // 
            // CalculateCorrectSalaryTest
            // 
            CalculateCorrectSalaryTest.ColumnNumber = 1;
            CalculateCorrectSalaryTest.Enabled = true;
            CalculateCorrectSalaryTest.ExpectedValue = "200000";
            CalculateCorrectSalaryTest.Name = "CalculateCorrectSalaryTest";
            CalculateCorrectSalaryTest.NullExpected = false;
            CalculateCorrectSalaryTest.ResultSet = 1;
            CalculateCorrectSalaryTest.RowNumber = 1;
            // 
            // UpdateSalaryInformationTest
            // 
            UpdateSalaryInformationTest.ColumnNumber = 1;
            UpdateSalaryInformationTest.Enabled = true;
            UpdateSalaryInformationTest.ExpectedValue = "200000";
            UpdateSalaryInformationTest.Name = "UpdateSalaryInformationTest";
            UpdateSalaryInformationTest.NullExpected = false;
            UpdateSalaryInformationTest.ResultSet = 1;
            UpdateSalaryInformationTest.RowNumber = 1;
            // 
            // UpdateSalaryInformationTest_PretestAction
            // 
            resources.ApplyResources(UpdateSalaryInformationTest_PretestAction, "UpdateSalaryInformationTest_PretestAction");
            // 
            // TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZeroData
            // 
            this.TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZeroData.PosttestAction = null;
            this.TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZeroData.PretestAction = null;
            this.TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZeroData.TestAction = TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero_TestAction;
            // 
            // TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero_TestAction
            // 
            TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero_TestAction.Conditions.Add(TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero);
            resources.ApplyResources(TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero_TestAction, "TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero_TestAction");
            // 
            // TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero
            // 
            TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero.ColumnNumber = 1;
            TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero.Enabled = true;
            TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero.ExpectedValue = "0";
            TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero.Name = "TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero";
            TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero.NullExpected = false;
            TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero.ResultSet = 1;
            TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero.RowNumber = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void CalculateCorrectSalaryTest()
        {
            SqlDatabaseTestActions testActions = this.CalculateCorrectSalaryTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void UpdateSalaryInformationTest()
        {
            SqlDatabaseTestActions testActions = this.UpdateSalaryInformationTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZero()
        {
            SqlDatabaseTestActions testActions = this.TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZeroData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        private SqlDatabaseTestActions CalculateCorrectSalaryTestData;
        private SqlDatabaseTestActions UpdateSalaryInformationTestData;
        private SqlDatabaseTestActions TestIfAgeANDLengthIsNegativeValueORLessthanZeroThenSalaryIsZeroData;
    }
}
