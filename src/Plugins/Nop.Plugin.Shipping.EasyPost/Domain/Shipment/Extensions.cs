using EasyPost;
using EasyPost.Models.API;

namespace Nop.Plugin.Shipping.EasyPost.Domain.Shipment
{
    /// <summary>
    /// Represents domain extensions
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Check whether two object instances are matches
        /// </summary>
        /// <param name="parcel">Parcel</param>
        /// <param name="parcel1">Parcel</param>
        /// <returns>Result</returns>
        public static bool Matches(this Parcel parcel, Parcel parcel1)
        {
            if (parcel1 is null)
                return false;

            return parcel.Weight == parcel1.Weight &&
                parcel.Width == parcel1.Width &&
                parcel.Length == parcel1.Length &&
                parcel.Height == parcel1.Height &&
                string.Equals(parcel.PredefinedPackage, parcel1.PredefinedPackage, System.StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Check whether two object instances are matches
        /// </summary>
        /// <param name="address">Address</param>
        /// <param name="address1">Address</param>
        /// <returns>Result</returns>
        public static bool Matches(this Address address, Address address1)
        {
            if (address1 is null)
                return false;

            return string.Equals(address.Street1, address1.Street1, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(address.City, address1.City, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(address.State, address1.State, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(address.Country, address1.Country, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(address.Zip, address1.Zip, System.StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Check whether two object instances are matches
        /// </summary>
        /// <param name="options">Options</param>
        /// <param name="options1">Options</param>
        /// <returns>Result</returns>
        public static bool Matches(this Options options, Options options1)
        {
            if (options1 is null)
                return false;

            return options.AdditionalHandling == options1.AdditionalHandling &&
                options.Alcohol == options1.Alcohol &&
                options.ByDrone == options1.ByDrone &&
                options.CarbonNeutral == options1.CarbonNeutral &&
                string.Equals(options.DeliveryConfirmation, options1.DeliveryConfirmation, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(options.Endorsement, options1.Endorsement, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(options.HandlingInstructions, options1.HandlingInstructions, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(options.Hazmat, options1.Hazmat, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(options.InvoiceNumber, options1.InvoiceNumber, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(options.Machinable, options1.Machinable, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(options.PrintCustom1, options1.PrintCustom1, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(options.PrintCustom1Code, options1.PrintCustom1Code, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(options.PrintCustom2, options1.PrintCustom2, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(options.PrintCustom2Code, options1.PrintCustom2Code, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(options.PrintCustom3, options1.PrintCustom3, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(options.PrintCustom3Code, options1.PrintCustom3Code, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(options.SpecialRatesEligibility, options1.SpecialRatesEligibility, System.StringComparison.InvariantCultureIgnoreCase) &&
                options.CertifiedMail == options1.CertifiedMail &&
                options.RegisteredMail == options1.RegisteredMail &&
                options.RegisteredMailAmount == options1.RegisteredMailAmount &&
                options.ReturnReceipt == options1.ReturnReceipt;
        }

        /// <summary>
        /// Check whether two object instances are matches
        /// </summary>
        /// <param name="customsInfo">Customs info</param>
        /// <param name="customsInfo1">Customs info</param>
        /// <returns>Result</returns>
        public static bool Matches(this CustomsInfo customsInfo, CustomsInfo customsInfo1)
        {
            if (customsInfo1 is null)
                return false;

            return string.Equals(customsInfo.ContentsType, customsInfo1.ContentsType, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(customsInfo.RestrictionType, customsInfo1.RestrictionType, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(customsInfo.NonDeliveryOption, customsInfo1.NonDeliveryOption, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(customsInfo.ContentsExplanation, customsInfo1.ContentsExplanation, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(customsInfo.RestrictionComments, customsInfo1.RestrictionComments, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(customsInfo.CustomsCertify, customsInfo1.CustomsCertify, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(customsInfo.CustomsSigner, customsInfo1.CustomsSigner, System.StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(customsInfo.EelPfc, customsInfo1.EelPfc, System.StringComparison.InvariantCultureIgnoreCase);
        }
    }
}