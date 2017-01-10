<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="RouteAnalysis.Cloud" generation="1" functional="0" release="0" Id="c2950831-1bad-4318-9ba7-abbbc4daea7c" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="RouteAnalysis.CloudGroup" generation="1" functional="0" release="0">
      <settings>
        <aCS name="RouteAnalysis.Worker:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/RouteAnalysis.Cloud/RouteAnalysis.CloudGroup/MapRouteAnalysis.Worker:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="RouteAnalysis.WorkerInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/RouteAnalysis.Cloud/RouteAnalysis.CloudGroup/MapRouteAnalysis.WorkerInstances" />
          </maps>
        </aCS>
      </settings>
      <maps>
        <map name="MapRouteAnalysis.Worker:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/RouteAnalysis.Cloud/RouteAnalysis.CloudGroup/RouteAnalysis.Worker/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapRouteAnalysis.WorkerInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/RouteAnalysis.Cloud/RouteAnalysis.CloudGroup/RouteAnalysis.WorkerInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="RouteAnalysis.Worker" generation="1" functional="0" release="0" software="D:\Repos\ChainOfResponsability\RouteAnalysis\RouteAnalysis.Cloud\csx\Debug\roles\RouteAnalysis.Worker" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaWorkerHost.exe " memIndex="-1" hostingEnvironment="consoleroleadmin" hostingEnvironmentVersion="2">
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;RouteAnalysis.Worker&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;RouteAnalysis.Worker&quot; /&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/RouteAnalysis.Cloud/RouteAnalysis.CloudGroup/RouteAnalysis.WorkerInstances" />
            <sCSPolicyUpdateDomainMoniker name="/RouteAnalysis.Cloud/RouteAnalysis.CloudGroup/RouteAnalysis.WorkerUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/RouteAnalysis.Cloud/RouteAnalysis.CloudGroup/RouteAnalysis.WorkerFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="RouteAnalysis.WorkerUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="RouteAnalysis.WorkerFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="RouteAnalysis.WorkerInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
</serviceModel>