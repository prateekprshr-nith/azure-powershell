// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Extensions;

    /// <summary>Cluster profile.</summary>
    public partial class ClusterProfile
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject into a new instance of <see cref="ClusterProfile" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ClusterProfile(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_identityProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject>("identityProfile"), out var __jsonIdentityProfile) ? Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IdentityProfile.FromJson(__jsonIdentityProfile) : IdentityProfile;}
            {_authorizationProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject>("authorizationProfile"), out var __jsonAuthorizationProfile) ? Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.AuthorizationProfile.FromJson(__jsonAuthorizationProfile) : AuthorizationProfile;}
            {_secretsProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject>("secretsProfile"), out var __jsonSecretsProfile) ? Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.SecretsProfile.FromJson(__jsonSecretsProfile) : SecretsProfile;}
            {_connectivityProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject>("connectivityProfile"), out var __jsonConnectivityProfile) ? Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ConnectivityProfile.FromJson(__jsonConnectivityProfile) : ConnectivityProfile;}
            {_logAnalyticsProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject>("logAnalyticsProfile"), out var __jsonLogAnalyticsProfile) ? Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ClusterLogAnalyticsProfile.FromJson(__jsonLogAnalyticsProfile) : LogAnalyticsProfile;}
            {_prometheusProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject>("prometheusProfile"), out var __jsonPrometheusProfile) ? Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ClusterPrometheusProfile.FromJson(__jsonPrometheusProfile) : PrometheusProfile;}
            {_sshProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject>("sshProfile"), out var __jsonSshProfile) ? Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.SshProfile.FromJson(__jsonSshProfile) : SshProfile;}
            {_autoscaleProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject>("autoscaleProfile"), out var __jsonAutoscaleProfile) ? Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.AutoscaleProfile.FromJson(__jsonAutoscaleProfile) : AutoscaleProfile;}
            {_trinoProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject>("trinoProfile"), out var __jsonTrinoProfile) ? Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.TrinoProfile.FromJson(__jsonTrinoProfile) : TrinoProfile;}
            {_flinkProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject>("flinkProfile"), out var __jsonFlinkProfile) ? Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.FlinkProfile.FromJson(__jsonFlinkProfile) : FlinkProfile;}
            {_sparkProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject>("sparkProfile"), out var __jsonSparkProfile) ? Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.SparkProfile.FromJson(__jsonSparkProfile) : SparkProfile;}
            {_clusterVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonString>("clusterVersion"), out var __jsonClusterVersion) ? (string)__jsonClusterVersion : (string)ClusterVersion;}
            {_ossVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonString>("ossVersion"), out var __jsonOssVersion) ? (string)__jsonOssVersion : (string)OssVersion;}
            {_component = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonArray>("components"), out var __jsonComponents) ? If( __jsonComponents as Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterComponentsItem>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterComponentsItem) (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ClusterComponentsItem.FromJson(__u) )) ))() : null : Component;}
            {_serviceConfigsProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonArray>("serviceConfigsProfiles"), out var __jsonServiceConfigsProfiles) ? If( __jsonServiceConfigsProfiles as Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterServiceConfigsProfile>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterServiceConfigsProfile) (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ClusterServiceConfigsProfile.FromJson(__p) )) ))() : null : ServiceConfigsProfile;}
            {_kafkaProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject>("kafkaProfile"), out var __jsonKafkaProfile) ? Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ClusterProfileKafkaProfile.FromJson(__jsonKafkaProfile) : KafkaProfile;}
            {_llapProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject>("llapProfile"), out var __jsonLlapProfile) ? Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ClusterProfileLlapProfile.FromJson(__jsonLlapProfile) : LlapProfile;}
            {_stubProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject>("stubProfile"), out var __jsonStubProfile) ? Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ClusterProfileStubProfile.FromJson(__jsonStubProfile) : StubProfile;}
            {_scriptActionProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonArray>("scriptActionProfiles"), out var __jsonScriptActionProfiles) ? If( __jsonScriptActionProfiles as Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IScriptActionProfile>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IScriptActionProfile) (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ScriptActionProfile.FromJson(__k) )) ))() : null : ScriptActionProfile;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterProfile.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterProfile.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterProfile FromJson(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject json ? new ClusterProfile(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ClusterProfile" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ClusterProfile" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._identityProfile ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) this._identityProfile.ToJson(null,serializationMode) : null, "identityProfile" ,container.Add );
            AddIf( null != this._authorizationProfile ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) this._authorizationProfile.ToJson(null,serializationMode) : null, "authorizationProfile" ,container.Add );
            AddIf( null != this._secretsProfile ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) this._secretsProfile.ToJson(null,serializationMode) : null, "secretsProfile" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._connectivityProfile ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) this._connectivityProfile.ToJson(null,serializationMode) : null, "connectivityProfile" ,container.Add );
            }
            AddIf( null != this._logAnalyticsProfile ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) this._logAnalyticsProfile.ToJson(null,serializationMode) : null, "logAnalyticsProfile" ,container.Add );
            AddIf( null != this._prometheusProfile ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) this._prometheusProfile.ToJson(null,serializationMode) : null, "prometheusProfile" ,container.Add );
            AddIf( null != this._sshProfile ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) this._sshProfile.ToJson(null,serializationMode) : null, "sshProfile" ,container.Add );
            AddIf( null != this._autoscaleProfile ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) this._autoscaleProfile.ToJson(null,serializationMode) : null, "autoscaleProfile" ,container.Add );
            AddIf( null != this._trinoProfile ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) this._trinoProfile.ToJson(null,serializationMode) : null, "trinoProfile" ,container.Add );
            AddIf( null != this._flinkProfile ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) this._flinkProfile.ToJson(null,serializationMode) : null, "flinkProfile" ,container.Add );
            AddIf( null != this._sparkProfile ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) this._sparkProfile.ToJson(null,serializationMode) : null, "sparkProfile" ,container.Add );
            AddIf( null != (((object)this._clusterVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonString(this._clusterVersion.ToString()) : null, "clusterVersion" ,container.Add );
            AddIf( null != (((object)this._ossVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonString(this._ossVersion.ToString()) : null, "ossVersion" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.SerializationMode.IncludeRead))
            {
                if (null != this._component)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.XNodeArray();
                    foreach( var __x in this._component )
                    {
                        AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                    }
                    container.Add("components",__w);
                }
            }
            if (null != this._serviceConfigsProfile)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.XNodeArray();
                foreach( var __s in this._serviceConfigsProfile )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("serviceConfigsProfiles",__r);
            }
            AddIf( null != this._kafkaProfile ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) this._kafkaProfile.ToJson(null,serializationMode) : null, "kafkaProfile" ,container.Add );
            AddIf( null != this._llapProfile ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) this._llapProfile.ToJson(null,serializationMode) : null, "llapProfile" ,container.Add );
            AddIf( null != this._stubProfile ? (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode) this._stubProfile.ToJson(null,serializationMode) : null, "stubProfile" ,container.Add );
            if (null != this._scriptActionProfile)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.XNodeArray();
                foreach( var __n in this._scriptActionProfile )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("scriptActionProfiles",__m);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}