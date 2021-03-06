﻿
using ScriptCs.Contracts;

namespace ScriptCs.OctopusClient
{
    public class OctopusClientScriptPack : IScriptPack
    {
        public void Initialize(IScriptPackSession session)
        {
            //Here you can perform initialization like pass using statements 
            //and references by using the session object's two methods:

            //AddReference
            //Use this method to add library references that need to be 
            //available in your script. After the script pack is loaded, 
            //the specified references will be available for use 
            //without any code inside the script.
            //session.AddReference("System.Net.Http.dll");

            //ImportNamespace
            //This method can import namespaces for use in your scripts to help 
            //keep user's scripts clean and simple.
            session.ImportNamespace("Octopus.Client");
            session.ImportNamespace("ScriptCs.Contracts");
            session.ImportNamespace("ScriptCs.OctopusClient");
        }

        public IScriptPackContext GetContext()
        {
            return new OctopusClientPack();
        }

        public void Terminate()
        {
            // clean up any resources here
        }
    }
}
