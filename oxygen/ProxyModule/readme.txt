﻿add ref to System, System.Web
then nuget  

 Install-Package Microsoft.AspNet.WebApi
 may be 

 Install-Package Microsoft.AspNet.Mvc -Version 5.2.2


 ensure this is in global.ascx

<%@ Application  Inherits="ProxyModule.WebApiApplication" Language="C#" %>


also need to add this to web conig

 <!--And, most importantly, this will tell your proxy not to use a proxy when making
  requests to the Internet (to avoid an endless loop of proxy requests-->
  <system.net>
    <defaultProxy enabled="false" />
  </system.net>
  <!--You’ll also need this in your web.config if you are going to host it in IIS (more on hosting options later)
  to tell IIS that you want the proxy code to handle all requests, no matter what!-->
  <system.webServer>
    <handlers>
      <remove name="ExtensionlessUrlHandler-Integrated-4.0" />
      <remove name="OPTIONSVerbHandler" />
      <remove name="TRACEVerbHandler" />
      <add name="ExtensionlessUrlHandler-Integrated-4.0" path="*." verb="*" type="System.Web.Handlers.TransferRequestHandler" preCondition="integratedMode,runtimeVersionv4.0" />
    </handlers>
  </system.webServer>

