﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;

namespace OTGEdit.XML
{
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/TCEE")]
    public class BiomeConfig
    {
        [DataMember]
        public string FileName = "";
        public string BiomeName
        {
            get
            {
                FileInfo f = new FileInfo(FileName);
                if (f != null)
                {
                    return f.Name.Replace("BiomeConfig.ini", "").Replace(".bc", "");
                }
                return null;
            }
        }

        [DataMember]
        public List<Property> Properties;

        public BiomeConfig(VersionConfig config)
        {
            Properties = new List<Property>();
            foreach (TCProperty property in config.BiomeConfig)
            {
                Properties.Add(new Property(null, false, property.Name, false, property.PropertyType != "BiomesList" && property.PropertyType != "ResourceQueue"));
            }
        }

        public void SetProperty(TCProperty property, string value, bool merge, bool overrideParentValues)
        {
            if (property.PropertyType != "String" && property.PropertyType != "BigString" && property.PropertyType != "BiomesList" && property.PropertyType != "ResourceQueue" && String.IsNullOrWhiteSpace(value))
            {
                value = null;
            }
            if (value != null)
            {
                value = value.Trim();
            }
            Properties.First(a => a.PropertyName == property.Name).Value = value;
            Properties.First(a => a.PropertyName == property.Name).Merge = merge;
            Properties.First(a => a.PropertyName == property.Name).OverrideParentValues = overrideParentValues;
        }

        public string GetPropertyValueAsString(TCProperty property)
        {
            Property prop = Properties.FirstOrDefault(a => a.PropertyName == property.Name);
            return prop != null ? prop.Value : null;
        }

        public bool GetPropertyMerge(TCProperty property)
        {
            Property prop = Properties.FirstOrDefault(a => a.PropertyName == property.Name);
            return prop != null ? prop.Merge : false;
        }

        public bool GetPropertyOverrideParentValues(TCProperty property)
        {
            Property prop = Properties.FirstOrDefault(a => a.PropertyName == property.Name);
            return prop != null ? prop.OverrideParentValues : false;
        }
    }
}
