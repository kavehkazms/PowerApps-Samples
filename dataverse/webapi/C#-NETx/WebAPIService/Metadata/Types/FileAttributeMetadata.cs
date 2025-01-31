﻿namespace PowerApps.Samples.Metadata.Types
{
    public  class FileAttributeMetadata : AttributeMetadata
    {

        public AttributeTypeCode AttributeType { get; } = AttributeTypeCode.Virtual;

        public AttributeTypeDisplayName AttributeTypeName { get; } = new AttributeTypeDisplayName(AttributeTypeDisplayNameValues.FileType);

        public int MaxSizeInKB { get; set; }
    }
}
