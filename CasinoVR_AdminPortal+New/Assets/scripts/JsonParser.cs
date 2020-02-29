using System;
using System.IO;
using Valve.Newtonsoft.Json;

public class JsonParser
{
    public AdminPortalJasonParser InitAdminPortalFromJson()
    {

        // gets a adminPortal.cs file from Assets/scritps folder, and then parses it according to AdminPortalJasonParser fields
        AdminPortalJasonParser admin = JsonConvert.DeserializeObject<AdminPortalJasonParser>(File.ReadAllText(@"Assets/scripts/AdminPortal.json"));
        return admin;
    }
}
