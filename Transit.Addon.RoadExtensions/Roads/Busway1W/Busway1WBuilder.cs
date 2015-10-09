﻿using Transit.Framework;
using Transit.Framework.Modularity;

namespace Transit.Addon.RoadExtensions.Roads.Busway1W
{
    public class Busway1WBuilder : SmallBuswayBuilderBase, INetInfoBuilder
    {
        public int Order { get { return 140; } }
        public int Priority { get { return 23; } }

        public string TemplatePrefabName { get { return NetInfos.Vanilla.ONEWAY_2L; } }
        public string Name { get { return "Small Busway OneWay"; } }
        public string DisplayName { get { return "Busway OneWay"; } }
        public string CodeName { get { return "BUSWAY_1W"; } }
        public string Description { get { return "A two-lane, one-way road suitable for buses only. Busway does not allow zoning next to it!"; } }

        public string ThumbnailsPath { get { return @"Roads\Busway1W\thumbnails.png"; } }
        public string InfoTooltipPath { get { return @"Roads\Busway1W\infotooltip.png"; } }

        public override void BuildUp(NetInfo info, NetInfoVersion version)
        {
            ///////////////////////////
            // Texturing             //
            ///////////////////////////
            switch (version)
            {
                case NetInfoVersion.Ground:
                    {
                        foreach (var segment in info.m_segments)
                        {
                            switch (segment.m_forwardRequired)
                            {
                                case NetSegment.Flags.StopLeft:
                                case NetSegment.Flags.StopRight:
                                    segment.SetTextures(
                                        new TexturesSet
                                           (@"Roads\Busway1W\Textures\Ground_Segment__MainTex.png",
                                            @"Roads\Busway2W\Textures\Ground_Segment__AlphaMap.png"),
                                        new TexturesSet
                                           (@"Roads\Busway2W\Textures\Ground_SegmentLOD_Bus__MainTex.png",
                                            @"Roads\Busway2W\Textures\Ground_SegmentLOD_Bus__AlphaMap.png",
                                            @"Roads\Busway2W\Textures\Ground_SegmentLOD__XYSMap.png"));
                                    break;

                                case NetSegment.Flags.StopBoth:
                                    segment.SetTextures(
                                        new TexturesSet
                                           (@"Roads\Busway1W\Textures\Ground_Segment__MainTex.png",
                                            @"Roads\Busway2W\Textures\Ground_Segment__AlphaMap.png"),
                                        new TexturesSet
                                           (@"Roads\Busway2W\Textures\Ground_SegmentLOD_BusBoth__MainTex.png",
                                            @"Roads\Busway2W\Textures\Ground_SegmentLOD_BusBoth__AlphaMap.png",
                                            @"Roads\Busway2W\Textures\Ground_SegmentLOD__XYSMap.png"));
                                    break;

                                default:
                                    segment.SetTextures(
                                        new TexturesSet
                                           (@"Roads\Busway1W\Textures\Ground_Segment__MainTex.png",
                                            @"Roads\Busway2W\Textures\Ground_Segment__AlphaMap.png"),
                                        new TexturesSet
                                           (@"Roads\Busway2W\Textures\Ground_SegmentLOD__MainTex.png",
                                            @"Roads\Busway2W\Textures\Ground_SegmentLOD__AlphaMap.png",
                                            @"Roads\Busway2W\Textures\Ground_SegmentLOD__XYSMap.png"));
                                    break;
                            }
                        }
                    }
                    break;

                case NetInfoVersion.Bridge:
                case NetInfoVersion.Elevated:
                    {
                        foreach (var segment in info.m_segments)
                        {
                            segment.SetTextures(
                                new TexturesSet
                                    (@"Roads\Busway1W\Textures\Elevated_Segment__MainTex.png",
                                     @"Roads\Busway2W\Textures\Elevated_Segment__AlphaMap.png"),
                                new TexturesSet
                                    (@"Roads\Busway2W\Textures\Elevated_SegmentLOD__MainTex.png",
                                     @"Roads\Busway2W\Textures\Elevated_SegmentLOD__AlphaMap.png",
                                     @"Roads\Busway2W\Textures\Elevated_SegmentLOD__XYSMap.png"));
                        }
                    }
                    break;
                case NetInfoVersion.Slope:
                    {
                        foreach (var segment in info.m_segments)
                        {
                            segment.SetTextures(
                                new TexturesSet
                                    (@"Roads\Busway1W\Textures\Slope_Segment__MainTex.png",
                                     @"Roads\Busway2W\Textures\Slope_Segment__AlphaMap.png"),
                                new TexturesSet
                                    (@"Roads\Busway2W\Textures\Slope_SegmentLOD__MainTex.png",
                                     @"Roads\Busway2W\Textures\Slope_SegmentLOD__AlphaMap.png",
                                     @"Roads\Busway2W\Textures\Slope_SegmentLOD__XYS.png"));
                        }
                    }
                    break;
                case NetInfoVersion.Tunnel:
                    break;
            }

            base.BuildUp(info, version);
        }
    }
}
