﻿//using Transit.Addon.RoadExtensions.Roads.Busway2L;
//using Transit.Framework;
//using Transit.Framework.Modularity;

//namespace Transit.Addon.RoadExtensions.Roads.Busway2L1W
//{
//    public class Busway2L1WGrassBuilder : Busway2LBuilderBase, INetInfoBuilder
//    {
//        public int Order { get { return 150; } }
//        public int UIOrder { get { return 24; } }

//        public string TemplateName { get { return NetInfos.Vanilla.ONEWAY_2L_GRASS; } }
//        public string Name { get { return "Small Busway OneWay Grass"; } } // TODO: Make sur the name fit with the existing T++ name
//        public string DisplayName { get { return "Busway OneWay with Grass"; } }
//        public string Description { get { return "A two-lane, one-way road with decorative grass suitable for buses only. Busway does not allow zoning next to it!"; } }

//        public string ThumbnailsPath { get { return @"Roads\Busway2L1W\thumbnails_grass.png"; } }
//        public string InfoTooltipPath { get { return @"Roads\Busway2L1W\infotooltip_grass.png"; } }

//        public override void BuildUp(NetInfo info, NetInfoVersion version)
//        {
//            ///////////////////////////
//            // Texturing             //
//            ///////////////////////////
//            switch (version)
//            {
//                case NetInfoVersion.Ground:
//                    {
//                        foreach (var segment in info.m_segments)
//                        {
//                            switch (segment.m_forwardRequired)
//                            {
//                                case NetSegment.Flags.StopLeft:
//                                case NetSegment.Flags.StopRight:
//                                    segment.SetTextures(
//                                        new TexturesSet
//                                           (@"Roads\Busway2L1W\Textures_Grass\Ground_Segment__MainTex.png",
//                                            @"Roads\Busway2L\Textures_Grass\Ground_Segment_Bus__AlphaMap.png"));
//                                    break;

//                                case NetSegment.Flags.StopBoth:
//                                    segment.SetTextures(
//                                        new TexturesSet
//                                           (@"Roads\Busway2L1W\Textures_Grass\Ground_Segment__MainTex.png",
//                                            @"Roads\Busway2L\Textures_Grass\Ground_Segment_BusBoth__AlphaMap.png"));
//                                    break;

//                                default:
//                                    segment.SetTextures(
//                                        new TexturesSet
//                                           (@"Roads\Busway2L1W\Textures_Grass\Ground_Segment__MainTex.png",
//                                            @"Roads\Busway2L\Textures_Grass\Ground_Segment__AlphaMap.png"));
//                                    break;
//                            }
//                        }
//                    }
//                    break;

//                case NetInfoVersion.Bridge:
//                case NetInfoVersion.Elevated:
//                    {
//                        foreach (var segment in info.m_segments)
//                        {
//                            segment.SetTextures(
//                                new TexturesSet
//                                    (@"Roads\Busway2L\Textures\Elevated_Segment__MainTex.png",
//                                     @"Roads\Busway2L\Textures\Elevated_Segment__AlphaMap.png"));
//                        }
//                    }
//                    break;
//                case NetInfoVersion.Slope:
//                    {
//                        foreach (var segment in info.m_segments)
//                        {
//                            segment.SetTextures(
//                                new TexturesSet
//                                    (@"Roads\Busway2L\Textures\Slope_Segment__MainTex.png",
//                                     @"Roads\Busway2L\Textures\Slope_Segment__AlphaMap.png"));
//                        }
//                    }
//                    break;
//                case NetInfoVersion.Tunnel:
//                    break;
//            }

//            base.BuildUp(info, version);
//        }
//    }
//}
