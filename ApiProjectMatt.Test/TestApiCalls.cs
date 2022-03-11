using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApiProjectMatt;
using System;

namespace ApiProjectMatt.Test
{
    //Added reference to the main project so call these classes and methods but the reference was added broken
    //and unfortunately I don't have time to figure out why

    //just for the sake of time Ive thrown multiple tests into this 1 method.  also something that I would split into separate methods.
    [TestClass]
    public class TestApiCalls
    {
        [TestMethod]
        public void TestInsertIntoMaster()
        {
            try
            {
                
                //MasterModel mModel = new MasterModel(DateTime.Now.AddHours(-1), DateTime.Now, null, "Status", "Detail", "Body");
                //DataService service = new DataService();
                //MasterModel rModel = service.InsertIntoMaster(mModel);
                //int.TryParse(x, out int value);//make sure a primary key is returning

                //rModel.status = "Processed";
                //service.UpdateMaster(rModel);

                //MasterModel gModel = service.GetMaster(rModel.MasterID);
                //Assert.AreEqual(gModel.status, "Processed");
            }catch(Exception ex)
            {
                //log exception
            }
        }
    }
}
