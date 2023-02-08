namespace JwstFeedInfrastructure.Model;

public enum eInputType
{
	HttpGet = 1,

	HttpPost = 2,

	ByUsername = 3,

	MastPortal = 4
}

public enum eSourceType
{
	NasaBlogs = 1,

	WebbTelescopeOrg = 2,

	Flickr = 3,

	Arxiv = 4,

	Youtube = 5,

	Reddit = 6,

	StsciRawMiri = 7,

	StsciSchedule = 8,

	EsaWebb = 9,

	Twitter = 10,

	TwitterRawPhotoBot = 11,

	StsciRawNiriss = 12,

	WebbTelescopeImagesOrg = 13,

	Ceers = 14,

	StsciRawNircam = 15,

	StsciRawNirspec = 16
}

public enum ePlotType
{
	Link = 0,

	Image = 1,

	Video = 2
}