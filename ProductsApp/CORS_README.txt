
<!--Add this to web.config to support Cross Origin Request Security (CORS)-->


<?xml version="1.0" encoding="utf-8"?>
<configuration>
 <system.webServer>
   <httpProtocol>
     <customHeaders>
       <add name="Access-Control-Allow-Origin" value="*" />
     </customHeaders>
   </httpProtocol>
 </system.webServer>
</configuration>