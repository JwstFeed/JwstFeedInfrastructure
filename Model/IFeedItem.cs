namespace JwstFeedInfrastructure.Model;

public interface IFeedItem
{
	string ClusterIndex { get; }

	DateTime DatePublished { get; }

	ePlotType PlotType { get; }

	string PlotUrl { get; }

	string ShortTitle { get; }

	eSourceType SourceType { get; }

	string SourceUrl { get; }

	string UniqueID { get; }

	string ThumbnailUrl { get; }
}