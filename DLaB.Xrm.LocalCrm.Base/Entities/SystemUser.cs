﻿using System.Diagnostics.CodeAnalysis;

namespace DLaB.Xrm.LocalCrm.Entities
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    internal class SystemUser
    {
        public struct Fields
        {
            public const string AccessMode = "accessmode";
            public const string Address1_AddressId = "address1_addressid";
            public const string Address1_AddressTypeCode = "address1_addresstypecode";
            public const string Address1_City = "address1_city";
            public const string Address1_Composite = "address1_composite";
            public const string Address1_Country = "address1_country";
            public const string Address1_County = "address1_county";
            public const string Address1_Fax = "address1_fax";
            public const string Address1_Latitude = "address1_latitude";
            public const string Address1_Line1 = "address1_line1";
            public const string Address1_Line2 = "address1_line2";
            public const string Address1_Line3 = "address1_line3";
            public const string Address1_Longitude = "address1_longitude";
            public const string Address1_Name = "address1_name";
            public const string Address1_PostalCode = "address1_postalcode";
            public const string Address1_PostOfficeBox = "address1_postofficebox";
            public const string Address1_ShippingMethodCode = "address1_shippingmethodcode";
            public const string Address1_StateOrProvince = "address1_stateorprovince";
            public const string Address1_Telephone1 = "address1_telephone1";
            public const string Address1_Telephone2 = "address1_telephone2";
            public const string Address1_Telephone3 = "address1_telephone3";
            public const string Address1_UPSZone = "address1_upszone";
            public const string Address1_UTCOffset = "address1_utcoffset";
            public const string Address2_AddressId = "address2_addressid";
            public const string Address2_AddressTypeCode = "address2_addresstypecode";
            public const string Address2_City = "address2_city";
            public const string Address2_Composite = "address2_composite";
            public const string Address2_Country = "address2_country";
            public const string Address2_County = "address2_county";
            public const string Address2_Fax = "address2_fax";
            public const string Address2_Latitude = "address2_latitude";
            public const string Address2_Line1 = "address2_line1";
            public const string Address2_Line2 = "address2_line2";
            public const string Address2_Line3 = "address2_line3";
            public const string Address2_Longitude = "address2_longitude";
            public const string Address2_Name = "address2_name";
            public const string Address2_PostalCode = "address2_postalcode";
            public const string Address2_PostOfficeBox = "address2_postofficebox";
            public const string Address2_ShippingMethodCode = "address2_shippingmethodcode";
            public const string Address2_StateOrProvince = "address2_stateorprovince";
            public const string Address2_Telephone1 = "address2_telephone1";
            public const string Address2_Telephone2 = "address2_telephone2";
            public const string Address2_Telephone3 = "address2_telephone3";
            public const string Address2_UPSZone = "address2_upszone";
            public const string Address2_UTCOffset = "address2_utcoffset";
            public const string BusinessUnitId = "businessunitid";
            public const string CalendarId = "calendarid";
            public const string CALType = "caltype";
            public const string CreatedBy = "createdby";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string DefaultFiltersPopulated = "defaultfilterspopulated";
            public const string DefaultMailbox = "defaultmailbox";
            public const string DisabledReason = "disabledreason";
            public const string DisplayInServiceViews = "displayinserviceviews";
            public const string DomainName = "domainname";
            public const string EmailRouterAccessApproval = "emailrouteraccessapproval";
            public const string EmployeeId = "employeeid";
            public const string EntityImage = "entityimage";
            public const string EntityImage_Timestamp = "entityimage_timestamp";
            public const string EntityImage_URL = "entityimage_url";
            public const string EntityImageId = "entityimageid";
            public const string ExchangeRate = "exchangerate";
            public const string FirstName = "firstname";
            public const string FullName = "fullname";
            public const string GovernmentId = "governmentid";
            public const string HomePhone = "homephone";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string IncomingEmailDeliveryMethod = "incomingemaildeliverymethod";
            public const string InternalEMailAddress = "internalemailaddress";
            public const string InviteStatusCode = "invitestatuscode";
            public const string IsDisabled = "isdisabled";
            public const string IsEmailAddressApprovedByO365Admin = "isemailaddressapprovedbyo365admin";
            public const string IsIntegrationUser = "isintegrationuser";
            public const string IsLicensed = "islicensed";
            public const string IsSyncWithDirectory = "issyncwithdirectory";
            public const string JobTitle = "jobtitle";
            public const string LastName = "lastname";
            public const string MiddleName = "middlename";
            public const string MobileAlertEMail = "mobilealertemail";
            public const string MobilePhone = "mobilephone";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string NickName = "nickname";
            public const string OrganizationId = "organizationid";
            public const string OutgoingEmailDeliveryMethod = "outgoingemaildeliverymethod";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string ParentSystemUserId = "parentsystemuserid";
            public const string PassportHi = "passporthi";
            public const string PassportLo = "passportlo";
            public const string PersonalEMailAddress = "personalemailaddress";
            public const string PhotoUrl = "photourl";
            public const string PositionId = "positionid";
            public const string PreferredAddressCode = "preferredaddresscode";
            public const string PreferredEmailCode = "preferredemailcode";
            public const string PreferredPhoneCode = "preferredphonecode";
            public const string ProcessId = "processid";
            public const string QueueId = "queueid";
            public const string Salutation = "salutation";
            public const string SetupUser = "setupuser";
            public const string SiteId = "siteid";
            public const string Skills = "skills";
            public const string StageId = "stageid";
            public const string SystemUserId = "systemuserid";
            public const string Id = "systemuserid";
            public const string TerritoryId = "territoryid";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string Title = "title";
            public const string TransactionCurrencyId = "transactioncurrencyid";
            public const string TraversedPath = "traversedpath";
            public const string UserLicenseType = "userlicensetype";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string WindowsLiveID = "windowsliveid";
            public const string YammerEmailAddress = "yammeremailaddress";
            public const string YammerUserId = "yammeruserid";
            public const string YomiFirstName = "yomifirstname";
            public const string YomiFullName = "yomifullname";
            public const string YomiLastName = "yomilastname";
            public const string YomiMiddleName = "yomimiddlename";
            public const string business_unit_system_users = "businessunitid";
            public const string calendar_system_users = "calendarid";
            public const string Referencinglk_systemuser_createdonbehalfby = "createdonbehalfby";
            public const string Referencinglk_systemuser_modifiedonbehalfby = "modifiedonbehalfby";
            public const string Referencinglk_systemuserbase_createdby = "createdby";
            public const string Referencinglk_systemuserbase_modifiedby = "modifiedby";
            public const string organization_system_users = "organizationid";
            public const string position_users = "positionid";
            public const string processstage_systemusers = "stageid";
            public const string queue_system_user = "queueid";
            public const string site_system_users = "siteid";
            public const string systemuser_defaultmailbox_mailbox = "defaultmailbox";
            public const string territory_system_users = "territoryid";
            public const string TransactionCurrency_SystemUser = "transactioncurrencyid";
            public const string Referencinguser_parent_user = "parentsystemuserid";
        }

        public const string EntityLogicalName = "systemuser";
    }
}
