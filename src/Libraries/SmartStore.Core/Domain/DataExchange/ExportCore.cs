﻿
namespace SmartStore.Core.Domain.DataExchange
{
	public enum ExportEntityType
	{
		Product = 0,
		Category,
		Manufacturer,
		Customer,
		Order,
		NewsletterSubscriber
	}

	public enum ExportDeploymentType
	{
		FileSystem = 0,
		Email,
		Http,
		Ftp
	}

	public enum ExportDescriptionMerging
	{
		None = 0,
		ShortDescriptionOrNameIfEmpty,
		ShortDescription,
		Description,
		NameAndShortDescription,
		NameAndDescription,
		ManufacturerAndNameAndShortDescription,
		ManufacturerAndNameAndDescription
	}

	public enum ExportProjectionSupport
	{
		Description = 0,
		Brand,
		MainPictureUrl,
		UseOwnProductNo,
		CategoryPath,
		ShippingTime,
		ShippingCosts,
		Availability,
		AttributeCombinationAsProduct,
		OldPrice
	}
}
