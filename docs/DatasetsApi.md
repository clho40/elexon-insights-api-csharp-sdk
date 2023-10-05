# Org.OpenAPITools.Api.DatasetsApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DatasetsABUCGet**](DatasetsApi.md#datasetsabucget) | **GET** /datasets/ABUC | Amount Of Balancing Reserves Under Contract (ABUC / B1720) |
| [**DatasetsABUCStreamGet**](DatasetsApi.md#datasetsabucstreamget) | **GET** /datasets/ABUC/stream | Amount Of Balancing Reserves Under Contract (ABUC / B1720) stream |
| [**DatasetsAGPTGet**](DatasetsApi.md#datasetsagptget) | **GET** /datasets/AGPT | Actual Aggregated Generation Per Type (AGPT / B1620) |
| [**DatasetsAGPTStreamGet**](DatasetsApi.md#datasetsagptstreamget) | **GET** /datasets/AGPT/stream | Actual Aggregated Generation Per Type (AGPT / B1620) stream |
| [**DatasetsAGWSGet**](DatasetsApi.md#datasetsagwsget) | **GET** /datasets/AGWS | Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630) |
| [**DatasetsAGWSStreamGet**](DatasetsApi.md#datasetsagwsstreamget) | **GET** /datasets/AGWS/stream | Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630) stream |
| [**DatasetsATLGet**](DatasetsApi.md#datasetsatlget) | **GET** /datasets/ATL | Actual Total Load Per Bidding Zone (ATL / B0610) |
| [**DatasetsATLStreamGet**](DatasetsApi.md#datasetsatlstreamget) | **GET** /datasets/ATL/stream | Actual Total Load Per Bidding Zone (ATL / B0610) stream |
| [**DatasetsB1610Get**](DatasetsApi.md#datasetsb1610get) | **GET** /datasets/B1610 | Actual Generation Output Per Generation Unit (B1610) |
| [**DatasetsB1610StreamGet**](DatasetsApi.md#datasetsb1610streamget) | **GET** /datasets/B1610/stream | Actual Generation Output Per Generation Unit (B1610) stream |
| [**DatasetsBOALFGet**](DatasetsApi.md#datasetsboalfget) | **GET** /datasets/BOALF | Bid Offer Acceptance Level Flagged (BOALF) |
| [**DatasetsBOALFStreamGet**](DatasetsApi.md#datasetsboalfstreamget) | **GET** /datasets/BOALF/stream | Bid Offer Acceptance Level Flagged Stream (BOALF) |
| [**DatasetsBODGet**](DatasetsApi.md#datasetsbodget) | **GET** /datasets/BOD | Bid Offer Data (BOD) |
| [**DatasetsBODStreamGet**](DatasetsApi.md#datasetsbodstreamget) | **GET** /datasets/BOD/stream | Bid Offer Data Stream (BOD) |
| [**DatasetsCCMGet**](DatasetsApi.md#datasetsccmget) | **GET** /datasets/CCM | Cost of Congestion Management (CCM / B1330) |
| [**DatasetsCCMStreamGet**](DatasetsApi.md#datasetsccmstreamget) | **GET** /datasets/CCM/stream | Cost of Congestion Management (CCM / B1330) stream |
| [**DatasetsCDNGet**](DatasetsApi.md#datasetscdnget) | **GET** /datasets/CDN | Credit Default Notice (CDN) |
| [**DatasetsCDNStreamGet**](DatasetsApi.md#datasetscdnstreamget) | **GET** /datasets/CDN/stream | Credit Default Notice (CDN) stream |
| [**DatasetsDAGGet**](DatasetsApi.md#datasetsdagget) | **GET** /datasets/DAG | Day-Ahead Aggregated Generation (DAG / B1430) |
| [**DatasetsDAGStreamGet**](DatasetsApi.md#datasetsdagstreamget) | **GET** /datasets/DAG/stream | Day-Ahead Aggregated Generation (DAG / B1430) stream |
| [**DatasetsDATLGet**](DatasetsApi.md#datasetsdatlget) | **GET** /datasets/DATL | Day-Ahead Total Load Forecast Per Bidding Zone (DATL / B0620) |
| [**DatasetsDATLStreamGet**](DatasetsApi.md#datasetsdatlstreamget) | **GET** /datasets/DATL/stream | Day-Ahead Total Load Forecast Per Bidding Zone (DATL / B0620) stream |
| [**DatasetsDCIGet**](DatasetsApi.md#datasetsdciget) | **GET** /datasets/DCI | Demand Control Instruction (DCI) |
| [**DatasetsDCIStreamGet**](DatasetsApi.md#datasetsdcistreamget) | **GET** /datasets/DCI/stream | Demand Control Instruction (DCI) stream |
| [**DatasetsDGWSGet**](DatasetsApi.md#datasetsdgwsget) | **GET** /datasets/DGWS | Day-Ahead Generation For Wind And Solar (DGWS / B1440) |
| [**DatasetsDGWSStreamGet**](DatasetsApi.md#datasetsdgwsstreamget) | **GET** /datasets/DGWS/stream | Day-Ahead Generation For Wind And Solar (DGWS / B1440) stream |
| [**DatasetsDISBSADGet**](DatasetsApi.md#datasetsdisbsadget) | **GET** /datasets/DISBSAD | Disaggregated Balancing Services Adjustment Data (DISBSAD) |
| [**DatasetsDISBSADStreamGet**](DatasetsApi.md#datasetsdisbsadstreamget) | **GET** /datasets/DISBSAD/stream | Disaggregated Balancing Services Adjustment Data (DISBSAD) stream |
| [**DatasetsFOU2T14DGet**](DatasetsApi.md#datasetsfou2t14dget) | **GET** /datasets/FOU2T14D | 2 to 14 Days Ahead Generation availability aggregated by Fuel Type (FOU2T14D) |
| [**DatasetsFOU2T3YWGet**](DatasetsApi.md#datasetsfou2t3ywget) | **GET** /datasets/FOU2T3YW | 2 to 156 Weeks Ahead Generation availability aggregated by Fuel Type (FOU2T3YW) |
| [**DatasetsFREQGet**](DatasetsApi.md#datasetsfreqget) | **GET** /datasets/FREQ | System Frequency (FREQ) |
| [**DatasetsFREQStreamGet**](DatasetsApi.md#datasetsfreqstreamget) | **GET** /datasets/FREQ/stream | System Frequency (FREQ) stream |
| [**DatasetsFUELHHGet**](DatasetsApi.md#datasetsfuelhhget) | **GET** /datasets/FUELHH | Half-hourly generation outturn by fuel type (FUELHH) |
| [**DatasetsFUELHHStreamGet**](DatasetsApi.md#datasetsfuelhhstreamget) | **GET** /datasets/FUELHH/stream | Half-hourly generation outturn by fuel type (FUELHH) stream |
| [**DatasetsFUELINSTGet**](DatasetsApi.md#datasetsfuelinstget) | **GET** /datasets/FUELINST | Instantaneous generation outturn by fuel type (FUELINST) |
| [**DatasetsFUELINSTStreamGet**](DatasetsApi.md#datasetsfuelinststreamget) | **GET** /datasets/FUELINST/stream | Instantaneous generation outturn by fuel type (FUELINST) stream |
| [**DatasetsIGCAGet**](DatasetsApi.md#datasetsigcaget) | **GET** /datasets/IGCA | Installed Generation Capacity Aggregated (IGCA / B1410) |
| [**DatasetsIGCAStreamGet**](DatasetsApi.md#datasetsigcastreamget) | **GET** /datasets/IGCA/stream | Installed Generation Capacity Aggregated (IGCA / B1410) stream |
| [**DatasetsIMBALNGCGet**](DatasetsApi.md#datasetsimbalngcget) | **GET** /datasets/IMBALNGC | Day and Day-Ahead Indicated Imbalance (IMBALNGC) |
| [**DatasetsIMBALNGCStreamGet**](DatasetsApi.md#datasetsimbalngcstreamget) | **GET** /datasets/IMBALNGC/stream | Day and Day-Ahead Indicated Imbalance stream |
| [**DatasetsINDDEMGet**](DatasetsApi.md#datasetsinddemget) | **GET** /datasets/INDDEM | Day and Day-Ahead Indicated Demand (INDDEM) |
| [**DatasetsINDDEMStreamGet**](DatasetsApi.md#datasetsinddemstreamget) | **GET** /datasets/INDDEM/stream | Day and Day-Ahead Indicated Demand stream |
| [**DatasetsINDGENGet**](DatasetsApi.md#datasetsindgenget) | **GET** /datasets/INDGEN | Day and Day-Ahead Indicated Generation (INDGEN) |
| [**DatasetsINDGENStreamGet**](DatasetsApi.md#datasetsindgenstreamget) | **GET** /datasets/INDGEN/stream | Day and Day-Ahead Indicated Generation stream |
| [**DatasetsINDODGet**](DatasetsApi.md#datasetsindodget) | **GET** /datasets/INDOD | Initial National Demand Outturn Daily (INDOD) |
| [**DatasetsINDODStreamGet**](DatasetsApi.md#datasetsindodstreamget) | **GET** /datasets/INDOD/stream | Initial National Demand Outturn Daily (INDOD) stream |
| [**DatasetsINDOGet**](DatasetsApi.md#datasetsindoget) | **GET** /datasets/INDO | Initial National Demand Outturn data (INDO) |
| [**DatasetsITSDOGet**](DatasetsApi.md#datasetsitsdoget) | **GET** /datasets/ITSDO | Initial Transmission System Outturn data (ITSDO) |
| [**DatasetsLOLPDRMGet**](DatasetsApi.md#datasetslolpdrmget) | **GET** /datasets/LOLPDRM | Loss of Load Probability and De-rated Margin (LOLPDRM) |
| [**DatasetsLOLPDRMStreamGet**](DatasetsApi.md#datasetslolpdrmstreamget) | **GET** /datasets/LOLPDRM/stream | Loss of Load Probability and De-rated Margin (LOLPDRM) stream |
| [**DatasetsMATLGet**](DatasetsApi.md#datasetsmatlget) | **GET** /datasets/MATL | Month-Ahead Total Load Forecast Per Bidding Zone (MATL / B0640) |
| [**DatasetsMATLStreamGet**](DatasetsApi.md#datasetsmatlstreamget) | **GET** /datasets/MATL/stream | Month-Ahead Total Load Forecast Per Bidding Zone (MATL / B0640) stream |
| [**DatasetsMDPGet**](DatasetsApi.md#datasetsmdpget) | **GET** /datasets/MDP | Maximum Delivery Period (MDP) |
| [**DatasetsMDPStreamGet**](DatasetsApi.md#datasetsmdpstreamget) | **GET** /datasets/MDP/stream | Maximum Delivery Period Stream (MDP) |
| [**DatasetsMDVGet**](DatasetsApi.md#datasetsmdvget) | **GET** /datasets/MDV | Maximum Delivery Volume (MDV) |
| [**DatasetsMDVStreamGet**](DatasetsApi.md#datasetsmdvstreamget) | **GET** /datasets/MDV/stream | Maximum Delivery Volume Stream (MDV) |
| [**DatasetsMELNGCGet**](DatasetsApi.md#datasetsmelngcget) | **GET** /datasets/MELNGC | Day and Day-Ahead Indicated Margin (MELNGC) |
| [**DatasetsMELNGCStreamGet**](DatasetsApi.md#datasetsmelngcstreamget) | **GET** /datasets/MELNGC/stream | Day and Day-Ahead Indicated Margin stream |
| [**DatasetsMELSGet**](DatasetsApi.md#datasetsmelsget) | **GET** /datasets/MELS | Maximum Export Limit (MELS) |
| [**DatasetsMELSStreamGet**](DatasetsApi.md#datasetsmelsstreamget) | **GET** /datasets/MELS/stream | Maximum Export Limit Stream (MELS) |
| [**DatasetsMIDGet**](DatasetsApi.md#datasetsmidget) | **GET** /datasets/MID | Market Index Data (MID) |
| [**DatasetsMIDStreamGet**](DatasetsApi.md#datasetsmidstreamget) | **GET** /datasets/MID/stream | Market Index Data Stream (MID) |
| [**DatasetsMILSGet**](DatasetsApi.md#datasetsmilsget) | **GET** /datasets/MILS | Maximum Import Limit (MILS) |
| [**DatasetsMILSStreamGet**](DatasetsApi.md#datasetsmilsstreamget) | **GET** /datasets/MILS/stream | Maximum Import Limit Stream (MILS) |
| [**DatasetsMNZTGet**](DatasetsApi.md#datasetsmnztget) | **GET** /datasets/MNZT | Minimum Non-Zero Time (MNZT) |
| [**DatasetsMNZTStreamGet**](DatasetsApi.md#datasetsmnztstreamget) | **GET** /datasets/MNZT/stream | Minimum Non-Zero Time Stream (MNZT) |
| [**DatasetsMZTGet**](DatasetsApi.md#datasetsmztget) | **GET** /datasets/MZT | Minimum Zero Time (MZT) |
| [**DatasetsMZTStreamGet**](DatasetsApi.md#datasetsmztstreamget) | **GET** /datasets/MZT/stream | Minimum Zero Time Stream (MZT) |
| [**DatasetsMetadataLatestGet**](DatasetsApi.md#datasetsmetadatalatestget) | **GET** /datasets/metadata/latest | Returns the time when each dataset was last updated |
| [**DatasetsNDFDGet**](DatasetsApi.md#datasetsndfdget) | **GET** /datasets/NDFD | Demand and Surplus Forecast Data (2-14 days ahead) National Demand (NDFD) |
| [**DatasetsNDFDStreamGet**](DatasetsApi.md#datasetsndfdstreamget) | **GET** /datasets/NDFD/stream | Demand and Surplus Forecast Data (2-14 days ahead) National Demand (NDFD) |
| [**DatasetsNDFGet**](DatasetsApi.md#datasetsndfget) | **GET** /datasets/NDF | National Day and Day-Ahead National Demand Forecast (NDF) |
| [**DatasetsNDFStreamGet**](DatasetsApi.md#datasetsndfstreamget) | **GET** /datasets/NDF/stream | National Day and Day-Ahead National Demand Forecast stream |
| [**DatasetsNDFWGet**](DatasetsApi.md#datasetsndfwget) | **GET** /datasets/NDFW | Demand and Surplus Forecast Data (2-52 weeks ahead) National Demand (NDFW) |
| [**DatasetsNDFWStreamGet**](DatasetsApi.md#datasetsndfwstreamget) | **GET** /datasets/NDFW/stream | Demand and Surplus Forecast Data (2-52 weeks ahead) National Demand (NDFW) |
| [**DatasetsNDZGet**](DatasetsApi.md#datasetsndzget) | **GET** /datasets/NDZ | Notice to Deviate from Zero (NDZ) |
| [**DatasetsNDZStreamGet**](DatasetsApi.md#datasetsndzstreamget) | **GET** /datasets/NDZ/stream | Notice to Deviate from Zero Stream (NDZ) |
| [**DatasetsNETBSADGet**](DatasetsApi.md#datasetsnetbsadget) | **GET** /datasets/NETBSAD | Net Balancing Services Adjustment Data (NETBSAD) |
| [**DatasetsNETBSADStreamGet**](DatasetsApi.md#datasetsnetbsadstreamget) | **GET** /datasets/NETBSAD/stream | Net Balancing Services Adjustment Data (NETBSAD) |
| [**DatasetsNONBMGet**](DatasetsApi.md#datasetsnonbmget) | **GET** /datasets/NONBM | Non-BM STOR (NONBM) |
| [**DatasetsNONBMStreamGet**](DatasetsApi.md#datasetsnonbmstreamget) | **GET** /datasets/NONBM/stream | Non-BM STOR (NONBM) stream |
| [**DatasetsNOU2T14DGet**](DatasetsApi.md#datasetsnou2t14dget) | **GET** /datasets/NOU2T14D | 2 to 14 Days Ahead Generation availability aggregated data (NOU2T14D) |
| [**DatasetsNOU2T3YWGet**](DatasetsApi.md#datasetsnou2t3ywget) | **GET** /datasets/NOU2T3YW | 2 to 156 Weeks Ahead Generation availability aggregated data (NOU2T3YW) |
| [**DatasetsNTBGet**](DatasetsApi.md#datasetsntbget) | **GET** /datasets/NTB | Notice to Deliver Bids (NTB) |
| [**DatasetsNTBStreamGet**](DatasetsApi.md#datasetsntbstreamget) | **GET** /datasets/NTB/stream | Notice to Deliver Bids Stream (NTB) |
| [**DatasetsNTOGet**](DatasetsApi.md#datasetsntoget) | **GET** /datasets/NTO | Notice to Deliver Offers (NTO) |
| [**DatasetsNTOStreamGet**](DatasetsApi.md#datasetsntostreamget) | **GET** /datasets/NTO/stream | Notice to Deliver Offers Stream (NTO) |
| [**DatasetsOCNMF3Y2Get**](DatasetsApi.md#datasetsocnmf3y2get) | **GET** /datasets/OCNMF3Y2 | Demand and Surplus Forecast Data (2-156 weeks ahead) Generating Plant Demand Margin (OCNMF3Y2) |
| [**DatasetsOCNMF3Y2StreamGet**](DatasetsApi.md#datasetsocnmf3y2streamget) | **GET** /datasets/OCNMF3Y2/stream | Demand and Surplus Forecast Data (2-156 weeks ahead) Generating Plant Demand Margin (OCNMF3Y2) stream |
| [**DatasetsOCNMF3YGet**](DatasetsApi.md#datasetsocnmf3yget) | **GET** /datasets/OCNMF3Y | Demand and Surplus Forecast Data (2-156 weeks ahead) Surplus (OCNMF3Y) |
| [**DatasetsOCNMF3YStreamGet**](DatasetsApi.md#datasetsocnmf3ystreamget) | **GET** /datasets/OCNMF3Y/stream | Demand and Surplus Forecast Data (2-156 weeks ahead) Surplus (OCNMF3Y) stream |
| [**DatasetsOCNMFD2Get**](DatasetsApi.md#datasetsocnmfd2get) | **GET** /datasets/OCNMFD2 | Demand and Surplus Forecast Data (2-14 days ahead) Generating Plant Demand Margin (OCNMFD2) |
| [**DatasetsOCNMFD2StreamGet**](DatasetsApi.md#datasetsocnmfd2streamget) | **GET** /datasets/OCNMFD2/stream | Demand and Surplus Forecast Data (2-14 days ahead) Generating Plant Demand Margin stream |
| [**DatasetsOCNMFDGet**](DatasetsApi.md#datasetsocnmfdget) | **GET** /datasets/OCNMFD | Demand and Surplus Forecast Data (2-14 days ahead) Surplus (OCNMFD) |
| [**DatasetsOCNMFDStreamGet**](DatasetsApi.md#datasetsocnmfdstreamget) | **GET** /datasets/OCNMFD/stream | Demand and Surplus Forecast Data (2-14 days ahead) Surplus stream |
| [**DatasetsPNGet**](DatasetsApi.md#datasetspnget) | **GET** /datasets/PN | Physical Notifications (PN) |
| [**DatasetsPNStreamGet**](DatasetsApi.md#datasetspnstreamget) | **GET** /datasets/PN/stream | Physical Notifications Stream (PN) |
| [**DatasetsQASGet**](DatasetsApi.md#datasetsqasget) | **GET** /datasets/QAS | Balancing Services Volume (QAS) |
| [**DatasetsQASStreamGet**](DatasetsApi.md#datasetsqasstreamget) | **GET** /datasets/QAS/stream | Balancing Services Volume Stream (QAS) |
| [**DatasetsQPNGet**](DatasetsApi.md#datasetsqpnget) | **GET** /datasets/QPN | Quiescent Physical Notifications (QPN) |
| [**DatasetsQPNStreamGet**](DatasetsApi.md#datasetsqpnstreamget) | **GET** /datasets/QPN/stream | Quiescent Physical Notifications Stream (QPN) |
| [**DatasetsRDREGet**](DatasetsApi.md#datasetsrdreget) | **GET** /datasets/RDRE | Run Down Rate Export (RDRE) |
| [**DatasetsRDREStreamGet**](DatasetsApi.md#datasetsrdrestreamget) | **GET** /datasets/RDRE/stream | Run Down Rate Export (RDRE) Stream |
| [**DatasetsRDRIGet**](DatasetsApi.md#datasetsrdriget) | **GET** /datasets/RDRI | Run Down Rate Import (RDRI) |
| [**DatasetsRDRIStreamGet**](DatasetsApi.md#datasetsrdristreamget) | **GET** /datasets/RDRI/stream | Run Down Rate Import (RDRI) Stream |
| [**DatasetsREMITGet**](DatasetsApi.md#datasetsremitget) | **GET** /datasets/REMIT | The Regulation on Wholesale Energy Markets Integrity and Transparency (REMIT) |
| [**DatasetsREMITStreamGet**](DatasetsApi.md#datasetsremitstreamget) | **GET** /datasets/REMIT/stream | The Regulation on Wholesale Energy Markets Integrity and Transparency (REMIT) stream |
| [**DatasetsRUREGet**](DatasetsApi.md#datasetsrureget) | **GET** /datasets/RURE | Run Up Rate Export (RURE) |
| [**DatasetsRUREStreamGet**](DatasetsApi.md#datasetsrurestreamget) | **GET** /datasets/RURE/stream | Run Up Rate Export (RURE) Stream |
| [**DatasetsRURIGet**](DatasetsApi.md#datasetsruriget) | **GET** /datasets/RURI | Run Up Rate Import (RURI) |
| [**DatasetsRURIStreamGet**](DatasetsApi.md#datasetsruristreamget) | **GET** /datasets/RURI/stream | Run Up Rate Import (RURI) Stream |
| [**DatasetsSELGet**](DatasetsApi.md#datasetsselget) | **GET** /datasets/SEL | Stable Export Limit (SEL) |
| [**DatasetsSELStreamGet**](DatasetsApi.md#datasetsselstreamget) | **GET** /datasets/SEL/stream | Stable Export Limit Stream (SEL) |
| [**DatasetsSILGet**](DatasetsApi.md#datasetssilget) | **GET** /datasets/SIL | Stable Import Limit (SIL) |
| [**DatasetsSILStreamGet**](DatasetsApi.md#datasetssilstreamget) | **GET** /datasets/SIL/stream | Stable Import Limit Stream (SIL) |
| [**DatasetsSYSWARNGet**](DatasetsApi.md#datasetssyswarnget) | **GET** /datasets/SYSWARN | System Warnings (SYSWARN) |
| [**DatasetsSYSWARNStreamGet**](DatasetsApi.md#datasetssyswarnstreamget) | **GET** /datasets/SYSWARN/stream | System Warnings (SYSWARN) stream |
| [**DatasetsTEMPGet**](DatasetsApi.md#datasetstempget) | **GET** /datasets/TEMP | Temperature Data (TEMP) |
| [**DatasetsTSDFDGet**](DatasetsApi.md#datasetstsdfdget) | **GET** /datasets/TSDFD | Demand and Surplus Forecast Data (2-14 days ahead) Transmission System (TSDFD) |
| [**DatasetsTSDFDStreamGet**](DatasetsApi.md#datasetstsdfdstreamget) | **GET** /datasets/TSDFD/stream | Demand and Surplus Forecast Data (2-14 days ahead) Transmission System (TSDFD) stream |
| [**DatasetsTSDFGet**](DatasetsApi.md#datasetstsdfget) | **GET** /datasets/TSDF | Day and Day-Ahead Transmission System Demand Forecast (TSDF) |
| [**DatasetsTSDFStreamGet**](DatasetsApi.md#datasetstsdfstreamget) | **GET** /datasets/TSDF/stream | Day and Day-Ahead Transmission System Demand Forecast (TSDF) |
| [**DatasetsTSDFWGet**](DatasetsApi.md#datasetstsdfwget) | **GET** /datasets/TSDFW | Demand and Surplus Forecast Data (2-52 weeks ahead) Transmission System Demand (TSDFW) |
| [**DatasetsTSDFWStreamGet**](DatasetsApi.md#datasetstsdfwstreamget) | **GET** /datasets/TSDFW/stream | Demand and Surplus Forecast Data (2-52 weeks ahead) Transmission System Demand (TSDFW) |
| [**DatasetsUOU2T14DGet**](DatasetsApi.md#datasetsuou2t14dget) | **GET** /datasets/UOU2T14D | 2 to 14 Days Ahead Generation availability aggregated by Balancing Mechanism Units (UOU2T14D) |
| [**DatasetsUOU2T14DStreamGet**](DatasetsApi.md#datasetsuou2t14dstreamget) | **GET** /datasets/UOU2T14D/stream | 2 to 14 Days Ahead Generation availability aggregated by Balancing Mechanism Units Stream (UOU2T14D) |
| [**DatasetsUOU2T3YWGet**](DatasetsApi.md#datasetsuou2t3ywget) | **GET** /datasets/UOU2T3YW | 2 to 156 Weeks Ahead Generation availability aggregated by Balancing Mechanism Units (UOU2T3YW) |
| [**DatasetsUOU2T3YWStreamGet**](DatasetsApi.md#datasetsuou2t3ywstreamget) | **GET** /datasets/UOU2T3YW/stream | 2 to 156 Weeks Ahead Generation availability aggregated by Balancing Mechanism Units Stream (UOU2T3YW) |
| [**DatasetsWATLGet**](DatasetsApi.md#datasetswatlget) | **GET** /datasets/WATL | Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630) |
| [**DatasetsWATLStreamGet**](DatasetsApi.md#datasetswatlstreamget) | **GET** /datasets/WATL/stream | Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630) stream |
| [**DatasetsWINDFORGet**](DatasetsApi.md#datasetswindforget) | **GET** /datasets/WINDFOR | Wind Generation Forecast (WINDFOR) |
| [**DatasetsWINDFORStreamGet**](DatasetsApi.md#datasetswindforstreamget) | **GET** /datasets/WINDFOR/stream | Wind Generation Forecast (WINDFOR) |
| [**DatasetsYAFMGet**](DatasetsApi.md#datasetsyafmget) | **GET** /datasets/YAFM | Year Ahead Forecast Margin (YAFM / B0810) |
| [**DatasetsYAFMStreamGet**](DatasetsApi.md#datasetsyafmstreamget) | **GET** /datasets/YAFM/stream | Year Ahead Forecast Margin (YAFM / B0810) |
| [**DatasetsYATLGet**](DatasetsApi.md#datasetsyatlget) | **GET** /datasets/YATL | Year-Ahead Total Load Forecast Per Bidding Zone (YATL / B0650) |
| [**DatasetsYATLStreamGet**](DatasetsApi.md#datasetsyatlstreamget) | **GET** /datasets/YATL/stream | Year-Ahead Total Load Forecast Per Bidding Zone (YATL / B0650) stream |

<a id="datasetsabucget"></a>
# **DatasetsABUCGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsAbucDatasetRow DatasetsABUCGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

Amount Of Balancing Reserves Under Contract (ABUC / B1720)

This endpoint provides amount of balancing reserves under contract data.    This API endpoint has a maximum range of 2 years (731 days).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsABUCGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023-08-22T01:00:00Z;  // DateTime | 
            var publishDateTimeTo = 2023-08-23T01:00:00Z;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Amount Of Balancing Reserves Under Contract (ABUC / B1720)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsAbucDatasetRow result = apiInstance.DatasetsABUCGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsABUCGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsABUCGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Amount Of Balancing Reserves Under Contract (ABUC / B1720)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsAbucDatasetRow> response = apiInstance.DatasetsABUCGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsABUCGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsAbucDatasetRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsAbucDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsabucstreamget"></a>
# **DatasetsABUCStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsAbucDatasetRow&gt; DatasetsABUCStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

Amount Of Balancing Reserves Under Contract (ABUC / B1720) stream

This endpoint provides amount of balancing reserves under contract data.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsABUCStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023-08-22T01:00:00Z;  // DateTime | 
            var publishDateTimeTo = 2023-08-23T01:00:00Z;  // DateTime | 

            try
            {
                // Amount Of Balancing Reserves Under Contract (ABUC / B1720) stream
                List<InsightsApiModelsResponsesTransparencyDatasetRowsAbucDatasetRow> result = apiInstance.DatasetsABUCStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsABUCStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsABUCStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Amount Of Balancing Reserves Under Contract (ABUC / B1720) stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyDatasetRowsAbucDatasetRow>> response = apiInstance.DatasetsABUCStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsABUCStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsAbucDatasetRow&gt;**](InsightsApiModelsResponsesTransparencyDatasetRowsAbucDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsagptget"></a>
# **DatasetsAGPTGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualAggregatedGenerationPerTypeDatasetRow DatasetsAGPTGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

Actual Aggregated Generation Per Type (AGPT / B1620)

This endpoint provides actual generation data per settlement period aggregated by Power System Resource type (Fuel Type categories as defined by Commission Regulation (EU) No 543/2013).                This endpoint filters by publishTime and provides a maximum data output range of 4 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsAGPTGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023-07-18 18:00;  // DateTime | 
            var publishDateTimeTo = 2023-07-21 09:00;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Actual Aggregated Generation Per Type (AGPT / B1620)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualAggregatedGenerationPerTypeDatasetRow result = apiInstance.DatasetsAGPTGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsAGPTGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsAGPTGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Actual Aggregated Generation Per Type (AGPT / B1620)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualAggregatedGenerationPerTypeDatasetRow> response = apiInstance.DatasetsAGPTGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsAGPTGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualAggregatedGenerationPerTypeDatasetRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualAggregatedGenerationPerTypeDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsagptstreamget"></a>
# **DatasetsAGPTStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsActualAggregatedGenerationPerTypeDatasetRow&gt; DatasetsAGPTStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

Actual Aggregated Generation Per Type (AGPT / B1620) stream

This endpoint provides actual generation data per settlement period aggregated by Power System Resource type (Fuel Type categories as defined by Commission Regulation (EU) No 543/2013).                This endpoint filters by publishTime and has an optimised JSON payload aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsAGPTStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023-07-18 18:00;  // DateTime | 
            var publishDateTimeTo = 2023-07-21 09:00;  // DateTime | 

            try
            {
                // Actual Aggregated Generation Per Type (AGPT / B1620) stream
                List<InsightsApiModelsResponsesTransparencyDatasetRowsActualAggregatedGenerationPerTypeDatasetRow> result = apiInstance.DatasetsAGPTStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsAGPTStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsAGPTStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Actual Aggregated Generation Per Type (AGPT / B1620) stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyDatasetRowsActualAggregatedGenerationPerTypeDatasetRow>> response = apiInstance.DatasetsAGPTStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsAGPTStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsActualAggregatedGenerationPerTypeDatasetRow&gt;**](InsightsApiModelsResponsesTransparencyDatasetRowsActualAggregatedGenerationPerTypeDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsagwsget"></a>
# **DatasetsAGWSGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationWindSolarDatasetRow DatasetsAGWSGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630)

This endpoint provides actual or estimated wind and solar power generation  per settlement period. It returns generation with Power System Resource type  Solar, Wind Onshore or Wind Offshore (Fuel Type categories as defined by  Commission Regulation (EU) No 543/2013).                This API endpoint provides a maximum data output range of 7 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsAGWSGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023-07-27T10:00:00Z;  // DateTime | 
            var publishDateTimeTo = 2023-07-28T10:00:00Z;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationWindSolarDatasetRow result = apiInstance.DatasetsAGWSGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsAGWSGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsAGWSGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationWindSolarDatasetRow> response = apiInstance.DatasetsAGWSGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsAGWSGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationWindSolarDatasetRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationWindSolarDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsagwsstreamget"></a>
# **DatasetsAGWSStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationWindSolarDatasetRow&gt; DatasetsAGWSStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630) stream

This endpoint provides actual or estimated wind and solar power generation  per settlement period. It returns generation with Power System Resource type  Solar, Wind Onshore or Wind Offshore (Fuel Type categories as defined by  Commission Regulation (EU) No 543/2013).                This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsAGWSStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023-07-27T10:00:00Z;  // DateTime | 
            var publishDateTimeTo = 2023-07-28T10:00:00Z;  // DateTime | 

            try
            {
                // Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630) stream
                List<InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationWindSolarDatasetRow> result = apiInstance.DatasetsAGWSStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsAGWSStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsAGWSStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630) stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationWindSolarDatasetRow>> response = apiInstance.DatasetsAGWSStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsAGWSStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationWindSolarDatasetRow&gt;**](InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationWindSolarDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsatlget"></a>
# **DatasetsATLGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualTotalLoadPerBiddingZoneDatasetRow DatasetsATLGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

Actual Total Load Per Bidding Zone (ATL / B0610)

This endpoint provides actual total load per bidding zone data.    This API endpoint provides a maximum data output range of 7 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsATLGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023-07-18T07:00:00Z;  // DateTime | 
            var publishDateTimeTo = 2023-07-21T10:00:00Z;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Actual Total Load Per Bidding Zone (ATL / B0610)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualTotalLoadPerBiddingZoneDatasetRow result = apiInstance.DatasetsATLGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsATLGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsATLGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Actual Total Load Per Bidding Zone (ATL / B0610)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualTotalLoadPerBiddingZoneDatasetRow> response = apiInstance.DatasetsATLGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsATLGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualTotalLoadPerBiddingZoneDatasetRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualTotalLoadPerBiddingZoneDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsatlstreamget"></a>
# **DatasetsATLStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsActualTotalLoadPerBiddingZoneDatasetRow&gt; DatasetsATLStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

Actual Total Load Per Bidding Zone (ATL / B0610) stream

This endpoint provides actual total load per bidding zone data.                This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsATLStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023-07-18T07:00:00Z;  // DateTime | 
            var publishDateTimeTo = 2023-07-21T10:00:00Z;  // DateTime | 

            try
            {
                // Actual Total Load Per Bidding Zone (ATL / B0610) stream
                List<InsightsApiModelsResponsesTransparencyDatasetRowsActualTotalLoadPerBiddingZoneDatasetRow> result = apiInstance.DatasetsATLStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsATLStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsATLStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Actual Total Load Per Bidding Zone (ATL / B0610) stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyDatasetRowsActualTotalLoadPerBiddingZoneDatasetRow>> response = apiInstance.DatasetsATLStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsATLStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsActualTotalLoadPerBiddingZoneDatasetRow&gt;**](InsightsApiModelsResponsesTransparencyDatasetRowsActualTotalLoadPerBiddingZoneDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsb1610get"></a>
# **DatasetsB1610Get**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse DatasetsB1610Get (DateTime settlementDate, int settlementPeriod, List<string>? bmUnit = null, string? format = null)

Actual Generation Output Per Generation Unit (B1610)

This endpoint provides the actual generation output (MW) per Settlement Period and per generation unit of 100 MW or more installed generation capacity.                The information is published five days after the end of the operational period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsB1610GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var settlementDate = 2022-08-12T00:00Z;  // DateTime | 
            var settlementPeriod = 10;  // int | 
            var bmUnit = new List<string>?(); // List<string>? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Actual Generation Output Per Generation Unit (B1610)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse result = apiInstance.DatasetsB1610Get(settlementDate, settlementPeriod, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsB1610Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsB1610GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Actual Generation Output Per Generation Unit (B1610)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse> response = apiInstance.DatasetsB1610GetWithHttpInfo(settlementDate, settlementPeriod, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsB1610GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settlementDate** | **DateTime** |  |  |
| **settlementPeriod** | **int** |  |  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsb1610streamget"></a>
# **DatasetsB1610StreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse&gt; DatasetsB1610StreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Actual Generation Output Per Generation Unit (B1610) stream

This endpoint provides the actual generation output (MW) per Settlement Period and per generation unit of 100 MW or more installed generation capacity.                The information is published five days after the end of the operational period.                This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsB1610StreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-12T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-14T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                // Actual Generation Output Per Generation Unit (B1610) stream
                List<InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse> result = apiInstance.DatasetsB1610StreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsB1610StreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsB1610StreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Actual Generation Output Per Generation Unit (B1610) stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse>> response = apiInstance.DatasetsB1610StreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsB1610StreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse&gt;**](InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsboalfget"></a>
# **DatasetsBOALFGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsBidOfferAcceptanceLevelDatasetResponse DatasetsBOALFGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Bid Offer Acceptance Level Flagged (BOALF)

This endpoint provides bid offer acceptance data.                By default, the from and to parameters filter the data inclusively and this endpoint will return any data where  TimeFrom is within the requested time range. If the settlementPeriodFrom or settlementPeriodTo parameters are  provided, it will instead filter to return any data where TimeFrom is within the specified range of settlement  periods. It is possible to search using a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored.  For example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from datetime to datetime                    /datasets/boalf?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from datetime to settlement date and period:                    /datasets/boalf?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to datetime:                    /datasets/boalf?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/boalf?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsBOALFGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-10-22T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-10-23T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Bid Offer Acceptance Level Flagged (BOALF)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsBidOfferAcceptanceLevelDatasetResponse result = apiInstance.DatasetsBOALFGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsBOALFGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsBOALFGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bid Offer Acceptance Level Flagged (BOALF)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsBidOfferAcceptanceLevelDatasetResponse> response = apiInstance.DatasetsBOALFGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsBOALFGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsBidOfferAcceptanceLevelDatasetResponse**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsBidOfferAcceptanceLevelDatasetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsboalfstreamget"></a>
# **DatasetsBOALFStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDatasetRowsBidOfferAcceptanceLevelDatasetResponse&gt; DatasetsBOALFStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Bid Offer Acceptance Level Flagged Stream (BOALF)

This endpoint provides bid offer acceptance data.                By default, the from and to parameters filter the data inclusively and this endpoint will return any data where  TimeFrom is within the requested time range. If the settlementPeriodFrom or settlementPeriodTo parameters are  provided, it will instead filter to return any data where TimeFrom is within the specified range of settlement  periods. It is possible to search using a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored.  For example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from datetime to datetime                    /datasets/boalf/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from datetime to settlement date and period:                    /datasets/boalf/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to datetime:                    /datasets/boalf/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/boalf/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsBOALFStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-10-22T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-10-23T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Bid Offer Acceptance Level Flagged Stream (BOALF)
                List<InsightsApiModelsResponsesBalancingDatasetRowsBidOfferAcceptanceLevelDatasetResponse> result = apiInstance.DatasetsBOALFStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsBOALFStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsBOALFStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bid Offer Acceptance Level Flagged Stream (BOALF)
    ApiResponse<List<InsightsApiModelsResponsesBalancingDatasetRowsBidOfferAcceptanceLevelDatasetResponse>> response = apiInstance.DatasetsBOALFStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsBOALFStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDatasetRowsBidOfferAcceptanceLevelDatasetResponse&gt;**](InsightsApiModelsResponsesBalancingDatasetRowsBidOfferAcceptanceLevelDatasetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsbodget"></a>
# **DatasetsBODGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsBidOfferDatasetResponse DatasetsBODGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Bid Offer Data (BOD)

This endpoint provides bid-offer data.                By default, the from and to parameters filter the data inclusively and this endpoint will return any data where  TimeFrom is within the requested time range. If the settlementPeriodFrom or settlementPeriodTo parameters are  provided, it will instead filter to return any data where TimeFrom is within the specified range of settlement  periods. It is possible to search using a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored.  For example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from a datetime to a datetime                    /datasets/bod?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from a datetime to a settlement date and period:                    /datasets/bod?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from a settlement date and period to a datetime:                    /datasets/bod?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from a settlement date and period to a settlement date and period:                    /datasets/bod?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsBODGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-09-22T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-09-22T01:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Bid Offer Data (BOD)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsBidOfferDatasetResponse result = apiInstance.DatasetsBODGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsBODGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsBODGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bid Offer Data (BOD)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsBidOfferDatasetResponse> response = apiInstance.DatasetsBODGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsBODGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsBidOfferDatasetResponse**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsBidOfferDatasetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsbodstreamget"></a>
# **DatasetsBODStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDatasetRowsBidOfferDatasetResponse&gt; DatasetsBODStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Bid Offer Data Stream (BOD)

This endpoint provides bid-offer data.                By default, the from and to parameters filter the data inclusively and this endpoint will return any data where  TimeFrom is within the requested time range. If the settlementPeriodFrom or settlementPeriodTo parameters are  provided, it will instead filter to return any data where TimeFrom is within the specified range of settlement  periods. It is possible to search using a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored.  For example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from datetime to datetime                    /datasets/bod/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from datetime to settlement date and period:                    /datasets/bod/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to datetime:                    /datasets/bod/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/bod/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsBODStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-09-22T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-09-22T01:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Bid Offer Data Stream (BOD)
                List<InsightsApiModelsResponsesBalancingDatasetRowsBidOfferDatasetResponse> result = apiInstance.DatasetsBODStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsBODStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsBODStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bid Offer Data Stream (BOD)
    ApiResponse<List<InsightsApiModelsResponsesBalancingDatasetRowsBidOfferDatasetResponse>> response = apiInstance.DatasetsBODStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsBODStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDatasetRowsBidOfferDatasetResponse&gt;**](InsightsApiModelsResponsesBalancingDatasetRowsBidOfferDatasetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsccmget"></a>
# **DatasetsCCMGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsCostsOfCongestionManagementDatasetRow DatasetsCCMGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

Cost of Congestion Management (CCM / B1330)

This endpoint provides cost of congestion management data.    This API endpoint has a maximum range of 2 years (731 days).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsCCMGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-06-25T00:00Z;  // DateTime | 
            var publishDateTimeTo = 2022-07-25T00:00Z;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Cost of Congestion Management (CCM / B1330)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsCostsOfCongestionManagementDatasetRow result = apiInstance.DatasetsCCMGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsCCMGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsCCMGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cost of Congestion Management (CCM / B1330)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsCostsOfCongestionManagementDatasetRow> response = apiInstance.DatasetsCCMGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsCCMGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsCostsOfCongestionManagementDatasetRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsCostsOfCongestionManagementDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsccmstreamget"></a>
# **DatasetsCCMStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsCostsOfCongestionManagementDatasetRow&gt; DatasetsCCMStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

Cost of Congestion Management (CCM / B1330) stream

This endpoint provides cost of congestion management data.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsCCMStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-06-25T00:00Z;  // DateTime | 
            var publishDateTimeTo = 2022-07-25T00:00Z;  // DateTime | 

            try
            {
                // Cost of Congestion Management (CCM / B1330) stream
                List<InsightsApiModelsResponsesTransparencyDatasetRowsCostsOfCongestionManagementDatasetRow> result = apiInstance.DatasetsCCMStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsCCMStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsCCMStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cost of Congestion Management (CCM / B1330) stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyDatasetRowsCostsOfCongestionManagementDatasetRow>> response = apiInstance.DatasetsCCMStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsCCMStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsCostsOfCongestionManagementDatasetRow&gt;**](InsightsApiModelsResponsesTransparencyDatasetRowsCostsOfCongestionManagementDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetscdnget"></a>
# **DatasetsCDNGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsCreditDefaultNoticeDatasetResponse DatasetsCDNGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? bscPartyId = null, string? format = null)

Credit Default Notice (CDN)

This endpoint provides CDN Index Data received from EC.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsCDNGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-06-25T00:00:00Z;  // DateTime | 
            var publishDateTimeTo = 2022-06-26T00:00:00Z;  // DateTime | 
            var bscPartyId = INVE;  // string? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Credit Default Notice (CDN)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsCreditDefaultNoticeDatasetResponse result = apiInstance.DatasetsCDNGet(publishDateTimeFrom, publishDateTimeTo, bscPartyId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsCDNGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsCDNGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Credit Default Notice (CDN)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsCreditDefaultNoticeDatasetResponse> response = apiInstance.DatasetsCDNGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, bscPartyId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsCDNGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **bscPartyId** | **string?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsCreditDefaultNoticeDatasetResponse**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsCreditDefaultNoticeDatasetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetscdnstreamget"></a>
# **DatasetsCDNStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDatasetRowsCreditDefaultNoticeDatasetResponse&gt; DatasetsCDNStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? bscPartyId = null)

Credit Default Notice (CDN) stream

This endpoint provides CDN Index Data received from EC.                This endpoint has an optimised JSON payload and is aimed at frequent requests for the CDN data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsCDNStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-06-25T00:00:00Z;  // DateTime | 
            var publishDateTimeTo = 2022-06-26T00:00:00Z;  // DateTime | 
            var bscPartyId = INVE;  // string? |  (optional) 

            try
            {
                // Credit Default Notice (CDN) stream
                List<InsightsApiModelsResponsesBalancingDatasetRowsCreditDefaultNoticeDatasetResponse> result = apiInstance.DatasetsCDNStreamGet(publishDateTimeFrom, publishDateTimeTo, bscPartyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsCDNStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsCDNStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Credit Default Notice (CDN) stream
    ApiResponse<List<InsightsApiModelsResponsesBalancingDatasetRowsCreditDefaultNoticeDatasetResponse>> response = apiInstance.DatasetsCDNStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, bscPartyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsCDNStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **bscPartyId** | **string?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDatasetRowsCreditDefaultNoticeDatasetResponse&gt;**](InsightsApiModelsResponsesBalancingDatasetRowsCreditDefaultNoticeDatasetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsdagget"></a>
# **DatasetsDAGGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadAggregatedGenerationDatasetRow DatasetsDAGGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

Day-Ahead Aggregated Generation (DAG / B1430)

This endpoint provides day-ahead aggregated generation data.                It has a maximum date range of 7 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsDAGGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023-07-18 18:00;  // DateTime | 
            var publishDateTimeTo = 2023-07-21 09:00;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Day-Ahead Aggregated Generation (DAG / B1430)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadAggregatedGenerationDatasetRow result = apiInstance.DatasetsDAGGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsDAGGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsDAGGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day-Ahead Aggregated Generation (DAG / B1430)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadAggregatedGenerationDatasetRow> response = apiInstance.DatasetsDAGGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsDAGGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadAggregatedGenerationDatasetRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadAggregatedGenerationDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsdagstreamget"></a>
# **DatasetsDAGStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadAggregatedGenerationDatasetRow&gt; DatasetsDAGStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

Day-Ahead Aggregated Generation (DAG / B1430) stream

This endpoint provides day-ahead aggregated generation data.                This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsDAGStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023-07-18 18:00;  // DateTime | 
            var publishDateTimeTo = 2023-07-21 09:00;  // DateTime | 

            try
            {
                // Day-Ahead Aggregated Generation (DAG / B1430) stream
                List<InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadAggregatedGenerationDatasetRow> result = apiInstance.DatasetsDAGStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsDAGStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsDAGStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day-Ahead Aggregated Generation (DAG / B1430) stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadAggregatedGenerationDatasetRow>> response = apiInstance.DatasetsDAGStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsDAGStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadAggregatedGenerationDatasetRow&gt;**](InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadAggregatedGenerationDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsdatlget"></a>
# **DatasetsDATLGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadTotalLoadPerBiddingZoneDatasetRow DatasetsDATLGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

Day-Ahead Total Load Forecast Per Bidding Zone (DATL / B0620)

This endpoint provides day-ahead total load forecast per bidding zone data.    This API endpoint provides a maximum data output range of 7 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsDATLGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023/07/18 07:00;  // DateTime | 
            var publishDateTimeTo = 2023/07/21 10:00;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Day-Ahead Total Load Forecast Per Bidding Zone (DATL / B0620)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadTotalLoadPerBiddingZoneDatasetRow result = apiInstance.DatasetsDATLGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsDATLGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsDATLGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day-Ahead Total Load Forecast Per Bidding Zone (DATL / B0620)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadTotalLoadPerBiddingZoneDatasetRow> response = apiInstance.DatasetsDATLGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsDATLGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadTotalLoadPerBiddingZoneDatasetRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadTotalLoadPerBiddingZoneDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsdatlstreamget"></a>
# **DatasetsDATLStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadTotalLoadPerBiddingZoneDatasetRow&gt; DatasetsDATLStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

Day-Ahead Total Load Forecast Per Bidding Zone (DATL / B0620) stream

This endpoint provides day-ahead total load forecast per bidding zone data.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsDATLStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023/07/18 07:00;  // DateTime | 
            var publishDateTimeTo = 2023/07/21 10:00;  // DateTime | 

            try
            {
                // Day-Ahead Total Load Forecast Per Bidding Zone (DATL / B0620) stream
                List<InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadTotalLoadPerBiddingZoneDatasetRow> result = apiInstance.DatasetsDATLStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsDATLStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsDATLStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day-Ahead Total Load Forecast Per Bidding Zone (DATL / B0620) stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadTotalLoadPerBiddingZoneDatasetRow>> response = apiInstance.DatasetsDATLStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsDATLStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadTotalLoadPerBiddingZoneDatasetRow&gt;**](InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadTotalLoadPerBiddingZoneDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsdciget"></a>
# **DatasetsDCIGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsDemandControlInstructionDatasetRow DatasetsDCIGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Demand Control Instruction (DCI)

This endpoint provides demand control instruction data, filtered by publish time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsDCIGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2021-04-30T00:00Z;  // DateTime? |  (optional) 
            var publishDateTimeTo = 2021-05-30T20:00Z;  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Demand Control Instruction (DCI)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsDemandControlInstructionDatasetRow result = apiInstance.DatasetsDCIGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsDCIGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsDCIGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand Control Instruction (DCI)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsDemandControlInstructionDatasetRow> response = apiInstance.DatasetsDCIGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsDCIGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsDemandControlInstructionDatasetRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsDemandControlInstructionDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsdcistreamget"></a>
# **DatasetsDCIStreamGet**
> List&lt;InsightsApiModelsResponsesMiscDatasetRowsDemandControlInstructionDatasetRow&gt; DatasetsDCIStreamGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

Demand Control Instruction (DCI) stream

This endpoint provides demand control instruction data, filtered by publish time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsDCIStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2021-04-30T00:00Z;  // DateTime? |  (optional) 
            var publishDateTimeTo = 2021-05-30T20:00Z;  // DateTime? |  (optional) 

            try
            {
                // Demand Control Instruction (DCI) stream
                List<InsightsApiModelsResponsesMiscDatasetRowsDemandControlInstructionDatasetRow> result = apiInstance.DatasetsDCIStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsDCIStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsDCIStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand Control Instruction (DCI) stream
    ApiResponse<List<InsightsApiModelsResponsesMiscDatasetRowsDemandControlInstructionDatasetRow>> response = apiInstance.DatasetsDCIStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsDCIStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesMiscDatasetRowsDemandControlInstructionDatasetRow&gt;**](InsightsApiModelsResponsesMiscDatasetRowsDemandControlInstructionDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsdgwsget"></a>
# **DatasetsDGWSGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadGenerationForWindAndSolarDatasetRow DatasetsDGWSGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

Day-Ahead Generation For Wind And Solar (DGWS / B1440)

This endpoint provides day-ahead generation data for wind and solar.    This API endpoint provides a maximum data output range of 7 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsDGWSGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023/07/18 07:00;  // DateTime | 
            var publishDateTimeTo = 2023/07/21 10:00;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Day-Ahead Generation For Wind And Solar (DGWS / B1440)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadGenerationForWindAndSolarDatasetRow result = apiInstance.DatasetsDGWSGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsDGWSGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsDGWSGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day-Ahead Generation For Wind And Solar (DGWS / B1440)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadGenerationForWindAndSolarDatasetRow> response = apiInstance.DatasetsDGWSGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsDGWSGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadGenerationForWindAndSolarDatasetRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadGenerationForWindAndSolarDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsdgwsstreamget"></a>
# **DatasetsDGWSStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadGenerationForWindAndSolarDatasetRow&gt; DatasetsDGWSStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

Day-Ahead Generation For Wind And Solar (DGWS / B1440) stream

This endpoint provides day-ahead generation data for wind and solar.                This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsDGWSStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023/07/18 07:00;  // DateTime | 
            var publishDateTimeTo = 2023/07/21 10:00;  // DateTime | 

            try
            {
                // Day-Ahead Generation For Wind And Solar (DGWS / B1440) stream
                List<InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadGenerationForWindAndSolarDatasetRow> result = apiInstance.DatasetsDGWSStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsDGWSStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsDGWSStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day-Ahead Generation For Wind And Solar (DGWS / B1440) stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadGenerationForWindAndSolarDatasetRow>> response = apiInstance.DatasetsDGWSStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsDGWSStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadGenerationForWindAndSolarDatasetRow&gt;**](InsightsApiModelsResponsesTransparencyDatasetRowsDayAheadGenerationForWindAndSolarDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsdisbsadget"></a>
# **DatasetsDISBSADGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsDisaggregatedBalancingServicesAdjustmentData DatasetsDISBSADGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, string? format = null)

Disaggregated Balancing Services Adjustment Data (DISBSAD)

This endpoint provides Disaggregated Balancing Services Adjustment data received from NGESO.                Disaggregated Balancing Services Adjustment data covers a set of adjustment actions, cost and volume values  for each Settlement Period. Adjustment costs are shown in £. Adjustment volumes are shown in MWh.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/disbsad?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/disbsad?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/disbsad?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/disbsad?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsDISBSADGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-10-10T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-10-11T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Disaggregated Balancing Services Adjustment Data (DISBSAD)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsDisaggregatedBalancingServicesAdjustmentData result = apiInstance.DatasetsDISBSADGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsDISBSADGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsDISBSADGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disaggregated Balancing Services Adjustment Data (DISBSAD)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsDisaggregatedBalancingServicesAdjustmentData> response = apiInstance.DatasetsDISBSADGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsDISBSADGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsDisaggregatedBalancingServicesAdjustmentData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsDisaggregatedBalancingServicesAdjustmentData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsdisbsadstreamget"></a>
# **DatasetsDISBSADStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDatasetRowsDisaggregatedBalancingServicesAdjustmentData&gt; DatasetsDISBSADStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null)

Disaggregated Balancing Services Adjustment Data (DISBSAD) stream

This endpoint provides Disaggregated Balancing Services Adjustment data received from NGESO.                Disaggregated Balancing Services Adjustment data covers a set of adjustment actions, cost and volume values  for each Settlement Period. Adjustment costs are shown in £. Adjustment volumes are shown in MWh.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/disbsad/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/disbsad/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/disbsad/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/disbsad/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1    This endpoint has an optimised JSON payload and is aimed at frequent requests for DISBSAD data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsDISBSADStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-10-10T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-10-11T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 

            try
            {
                // Disaggregated Balancing Services Adjustment Data (DISBSAD) stream
                List<InsightsApiModelsResponsesBalancingDatasetRowsDisaggregatedBalancingServicesAdjustmentData> result = apiInstance.DatasetsDISBSADStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsDISBSADStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsDISBSADStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disaggregated Balancing Services Adjustment Data (DISBSAD) stream
    ApiResponse<List<InsightsApiModelsResponsesBalancingDatasetRowsDisaggregatedBalancingServicesAdjustmentData>> response = apiInstance.DatasetsDISBSADStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsDISBSADStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDatasetRowsDisaggregatedBalancingServicesAdjustmentData&gt;**](InsightsApiModelsResponsesBalancingDatasetRowsDisaggregatedBalancingServicesAdjustmentData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsfou2t14dget"></a>
# **DatasetsFOU2T14DGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByFuelTypeDaily DatasetsFOU2T14DGet (List<string>? fuelType = null, DateTime? publishDate = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, List<string>? biddingZone = null, bool? interconnector = null, string? format = null)

2 to 14 Days Ahead Generation availability aggregated by Fuel Type (FOU2T14D)

This endpoint provides a forward view of availability (also referred to as Output Usable data  under the Grid Code) for generation and interconnector capacity, accounting for planned outages  covering 2 days ahead to 14 days ahead; it is aggregated by Fuel Types categories.                Date parameter must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsFOU2T14DGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var fuelType = new List<string>?(); // List<string>? |  (optional) 
            var publishDate = 2022-09-20;  // DateTime? | The publish date for filtering. This must be in the format yyyy-MM-dd. (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var biddingZone = new List<string>?(); // List<string>? |  (optional) 
            var interconnector = true;  // bool? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // 2 to 14 Days Ahead Generation availability aggregated by Fuel Type (FOU2T14D)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByFuelTypeDaily result = apiInstance.DatasetsFOU2T14DGet(fuelType, publishDate, publishDateTimeFrom, publishDateTimeTo, biddingZone, interconnector, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsFOU2T14DGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsFOU2T14DGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 2 to 14 Days Ahead Generation availability aggregated by Fuel Type (FOU2T14D)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByFuelTypeDaily> response = apiInstance.DatasetsFOU2T14DGetWithHttpInfo(fuelType, publishDate, publishDateTimeFrom, publishDateTimeTo, biddingZone, interconnector, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsFOU2T14DGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fuelType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **publishDate** | **DateTime?** | The publish date for filtering. This must be in the format yyyy-MM-dd. | [optional]  |
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **biddingZone** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **interconnector** | **bool?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByFuelTypeDaily**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByFuelTypeDaily.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsfou2t3ywget"></a>
# **DatasetsFOU2T3YWGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByFuelTypeWeekly DatasetsFOU2T3YWGet (List<string>? fuelType = null, DateTime? publishDate = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, List<int>? week = null, List<int>? year = null, List<string>? biddingZone = null, bool? interconnector = null, string? format = null)

2 to 156 Weeks Ahead Generation availability aggregated by Fuel Type (FOU2T3YW)

This endpoint provides a forward view of availability (also referred to as Output Usable data  under the Grid Code) for generation and interconnector capacity, accounting for planned outages  covering availability data from 2 weeks ahead to 156 weeks ahead;  it is aggregated by Fuel Types categories.                Date parameter must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsFOU2T3YWGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var fuelType = new List<string>?(); // List<string>? |  (optional) 
            var publishDate = 2022-09-20;  // DateTime? | The publish date for filtering. This must be in the format yyyy-MM-dd. (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var week = new List<int>?(); // List<int>? |  (optional) 
            var year = new List<int>?(); // List<int>? |  (optional) 
            var biddingZone = new List<string>?(); // List<string>? |  (optional) 
            var interconnector = true;  // bool? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // 2 to 156 Weeks Ahead Generation availability aggregated by Fuel Type (FOU2T3YW)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByFuelTypeWeekly result = apiInstance.DatasetsFOU2T3YWGet(fuelType, publishDate, publishDateTimeFrom, publishDateTimeTo, week, year, biddingZone, interconnector, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsFOU2T3YWGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsFOU2T3YWGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 2 to 156 Weeks Ahead Generation availability aggregated by Fuel Type (FOU2T3YW)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByFuelTypeWeekly> response = apiInstance.DatasetsFOU2T3YWGetWithHttpInfo(fuelType, publishDate, publishDateTimeFrom, publishDateTimeTo, week, year, biddingZone, interconnector, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsFOU2T3YWGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fuelType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **publishDate** | **DateTime?** | The publish date for filtering. This must be in the format yyyy-MM-dd. | [optional]  |
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **week** | [**List&lt;int&gt;?**](int.md) |  | [optional]  |
| **year** | [**List&lt;int&gt;?**](int.md) |  | [optional]  |
| **biddingZone** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **interconnector** | **bool?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByFuelTypeWeekly**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByFuelTypeWeekly.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsfreqget"></a>
# **DatasetsFREQGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsSystemFrequency DatasetsFREQGet (DateTime? measurementDateTimeFrom = null, DateTime? measurementDateTimeTo = null, string? format = null)

System Frequency (FREQ)

The endpoint provides data that has been received every 2 minutes the Transmission System Frequency, expressed as a hertz value for one or more spot times within that 2 minute period.  The default output will be the latest published data.                A maximum limit of 24 hours is applied to this endpoint to limit response size. Use the streaming version  for larger response sizes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsFREQGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var measurementDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var measurementDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // System Frequency (FREQ)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsSystemFrequency result = apiInstance.DatasetsFREQGet(measurementDateTimeFrom, measurementDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsFREQGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsFREQGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // System Frequency (FREQ)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsSystemFrequency> response = apiInstance.DatasetsFREQGetWithHttpInfo(measurementDateTimeFrom, measurementDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsFREQGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **measurementDateTimeFrom** | **DateTime?** |  | [optional]  |
| **measurementDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsSystemFrequency**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsSystemFrequency.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsfreqstreamget"></a>
# **DatasetsFREQStreamGet**
> List&lt;InsightsApiModelsResponsesMiscDatasetRowsSystemFrequency&gt; DatasetsFREQStreamGet (DateTime? measurementDateTimeFrom = null, DateTime? measurementDateTimeTo = null)

System Frequency (FREQ) stream

The endpoint provides data that has been received every 2 minutes the Transmission System Frequency, expressed as a hertz value for one or more spot times within that 2 minute period.  The default output will be the latest published data.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the system frequency data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsFREQStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var measurementDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var measurementDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // System Frequency (FREQ) stream
                List<InsightsApiModelsResponsesMiscDatasetRowsSystemFrequency> result = apiInstance.DatasetsFREQStreamGet(measurementDateTimeFrom, measurementDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsFREQStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsFREQStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // System Frequency (FREQ) stream
    ApiResponse<List<InsightsApiModelsResponsesMiscDatasetRowsSystemFrequency>> response = apiInstance.DatasetsFREQStreamGetWithHttpInfo(measurementDateTimeFrom, measurementDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsFREQStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **measurementDateTimeFrom** | **DateTime?** |  | [optional]  |
| **measurementDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesMiscDatasetRowsSystemFrequency&gt;**](InsightsApiModelsResponsesMiscDatasetRowsSystemFrequency.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsfuelhhget"></a>
# **DatasetsFUELHHGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData DatasetsFUELHHGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, DateTime? settlementDateFrom = null, DateTime? settlementDateTo = null, List<int>? settlementPeriod = null, List<string>? fuelType = null, string? format = null)

Half-hourly generation outturn by fuel type (FUELHH)

This endpoint provides the half-hourly generation outturn (Generation By Fuel type)  to give our users an indication of the generation outturn for Great Britain.  The data is aggregated by Fuel Type category and updated at 30-minute intervals with  average MW values over 30 minutes for each category.                This endpoint includes additional Settlement parameters such as Settlement Dates and Settlement Period.  The Settlement Date fields cannot be set when a Publish Date field is set.                Settlement date parameters must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsFUELHHGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-06-25T00:00:00Z;  // DateTime? |  (optional) 
            var publishDateTimeTo = 2022-06-26T00:00:00Z;  // DateTime? |  (optional) 
            var settlementDateFrom = 2022-09-20;  // DateTime? |  (optional) 
            var settlementDateTo = 2022-09-21;  // DateTime? |  (optional) 
            var settlementPeriod = new List<int>?(); // List<int>? | List of Settlement Periods (optional) 
            var fuelType = new List<string>?(); // List<string>? | Fuel Type e.g. NUCLEAR (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Half-hourly generation outturn by fuel type (FUELHH)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData result = apiInstance.DatasetsFUELHHGet(publishDateTimeFrom, publishDateTimeTo, settlementDateFrom, settlementDateTo, settlementPeriod, fuelType, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsFUELHHGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsFUELHHGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Half-hourly generation outturn by fuel type (FUELHH)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData> response = apiInstance.DatasetsFUELHHGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, settlementDateFrom, settlementDateTo, settlementPeriod, fuelType, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsFUELHHGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **settlementDateFrom** | **DateTime?** |  | [optional]  |
| **settlementDateTo** | **DateTime?** |  | [optional]  |
| **settlementPeriod** | [**List&lt;int&gt;?**](int.md) | List of Settlement Periods | [optional]  |
| **fuelType** | [**List&lt;string&gt;?**](string.md) | Fuel Type e.g. NUCLEAR | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsfuelhhstreamget"></a>
# **DatasetsFUELHHStreamGet**
> List&lt;InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData&gt; DatasetsFUELHHStreamGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, DateTime? settlementDateFrom = null, DateTime? settlementDateTo = null, List<int>? settlementPeriod = null, List<string>? fuelType = null)

Half-hourly generation outturn by fuel type (FUELHH) stream

This endpoint provides the half-hourly generation outturn (Generation By Fuel type)  to give our users an indication of the generation outturn for Great Britain.  The data is aggregated by Fuel Type category and updated at 30-minute intervals with  average MW values over 30 minutes for each category.                This endpoint includes additional Settlement parameters such as Settlement Dates and Settlement Period.  The Settlement Date fields cannot be set when a Publish Date field is set.                Settlement date parameters must be provided in the exact format yyyy-MM-dd.                This endpoint has an optimised JSON payload and is aimed at frequent requests for the half-hourly generation outturn by fuel type (FUELHH) data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsFUELHHStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-06-25T00:00:00Z;  // DateTime? |  (optional) 
            var publishDateTimeTo = 2022-06-26T00:00:00Z;  // DateTime? |  (optional) 
            var settlementDateFrom = 2022-09-20;  // DateTime? |  (optional) 
            var settlementDateTo = 2022-09-21;  // DateTime? |  (optional) 
            var settlementPeriod = new List<int>?(); // List<int>? | List of Settlement Periods (optional) 
            var fuelType = new List<string>?(); // List<string>? | Fuel Type e.g. NUCLEAR (optional) 

            try
            {
                // Half-hourly generation outturn by fuel type (FUELHH) stream
                List<InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData> result = apiInstance.DatasetsFUELHHStreamGet(publishDateTimeFrom, publishDateTimeTo, settlementDateFrom, settlementDateTo, settlementPeriod, fuelType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsFUELHHStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsFUELHHStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Half-hourly generation outturn by fuel type (FUELHH) stream
    ApiResponse<List<InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData>> response = apiInstance.DatasetsFUELHHStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, settlementDateFrom, settlementDateTo, settlementPeriod, fuelType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsFUELHHStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **settlementDateFrom** | **DateTime?** |  | [optional]  |
| **settlementDateTo** | **DateTime?** |  | [optional]  |
| **settlementPeriod** | [**List&lt;int&gt;?**](int.md) | List of Settlement Periods | [optional]  |
| **fuelType** | [**List&lt;string&gt;?**](string.md) | Fuel Type e.g. NUCLEAR | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData&gt;**](InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsfuelinstget"></a>
# **DatasetsFUELINSTGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData DatasetsFUELINSTGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, DateTime? settlementDateFrom = null, DateTime? settlementDateTo = null, List<int>? settlementPeriod = null, List<string>? fuelType = null, string? format = null)

Instantaneous generation outturn by fuel type (FUELINST)

This endpoint provides the instantaneous generation outturn (Generation By Fuel type)  to give our users an indication of the generation outturn for Great Britain.  The data is aggregated by Fuel Type category and updated at five-minute intervals  with average MW values over 5 minutes for each category.                This endpoint includes additional Settlement parameters such as Settlement Dates and Settlement Period.  The Settlement Date fields cannot be set when a Publish Date field is set.                Settlement date parameters must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsFUELINSTGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-06-20T00:00:00Z;  // DateTime? |  (optional) 
            var publishDateTimeTo = 2022-06-26T00:00:00Z;  // DateTime? |  (optional) 
            var settlementDateFrom = 2022-09-20;  // DateTime? |  (optional) 
            var settlementDateTo = 2022-09-21;  // DateTime? |  (optional) 
            var settlementPeriod = new List<int>?(); // List<int>? | List of Settlement Periods (optional) 
            var fuelType = new List<string>?(); // List<string>? | Fuel Type e.g. NUCLEAR (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Instantaneous generation outturn by fuel type (FUELINST)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData result = apiInstance.DatasetsFUELINSTGet(publishDateTimeFrom, publishDateTimeTo, settlementDateFrom, settlementDateTo, settlementPeriod, fuelType, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsFUELINSTGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsFUELINSTGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Instantaneous generation outturn by fuel type (FUELINST)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData> response = apiInstance.DatasetsFUELINSTGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, settlementDateFrom, settlementDateTo, settlementPeriod, fuelType, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsFUELINSTGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **settlementDateFrom** | **DateTime?** |  | [optional]  |
| **settlementDateTo** | **DateTime?** |  | [optional]  |
| **settlementPeriod** | [**List&lt;int&gt;?**](int.md) | List of Settlement Periods | [optional]  |
| **fuelType** | [**List&lt;string&gt;?**](string.md) | Fuel Type e.g. NUCLEAR | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsfuelinststreamget"></a>
# **DatasetsFUELINSTStreamGet**
> List&lt;InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData&gt; DatasetsFUELINSTStreamGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, DateTime? settlementDateFrom = null, DateTime? settlementDateTo = null, List<int>? settlementPeriod = null, List<string>? fuelType = null)

Instantaneous generation outturn by fuel type (FUELINST) stream

This endpoint provides the instantaneous generation outturn (Generation By Fuel type)  to give our users an indication of the generation outturn for Great Britain.  The data is aggregated by Fuel Type category and updated at five-minute intervals  with average MW values over 5 minutes for each category.                This endpoint includes additional Settlement parameters such as Settlement Dates and Settlement Period.  The Settlement Date fields cannot be set when a Publish Date field is set.                Settlement date parameters must be provided in the exact format yyyy-MM-dd.    This endpoint has an optimised JSON payload and is aimed at frequent requests for instantaneous generation outturn by fuel type (FUELINST) data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsFUELINSTStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-06-20T00:00:00Z;  // DateTime? |  (optional) 
            var publishDateTimeTo = 2022-06-26T00:00:00Z;  // DateTime? |  (optional) 
            var settlementDateFrom = 2022-09-20;  // DateTime? |  (optional) 
            var settlementDateTo = 2022-09-21;  // DateTime? |  (optional) 
            var settlementPeriod = new List<int>?(); // List<int>? | List of Settlement Periods (optional) 
            var fuelType = new List<string>?(); // List<string>? | Fuel Type e.g. NUCLEAR (optional) 

            try
            {
                // Instantaneous generation outturn by fuel type (FUELINST) stream
                List<InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData> result = apiInstance.DatasetsFUELINSTStreamGet(publishDateTimeFrom, publishDateTimeTo, settlementDateFrom, settlementDateTo, settlementPeriod, fuelType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsFUELINSTStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsFUELINSTStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Instantaneous generation outturn by fuel type (FUELINST) stream
    ApiResponse<List<InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData>> response = apiInstance.DatasetsFUELINSTStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, settlementDateFrom, settlementDateTo, settlementPeriod, fuelType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsFUELINSTStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **settlementDateFrom** | **DateTime?** |  | [optional]  |
| **settlementDateTo** | **DateTime?** |  | [optional]  |
| **settlementPeriod** | [**List&lt;int&gt;?**](int.md) | List of Settlement Periods | [optional]  |
| **fuelType** | [**List&lt;string&gt;?**](string.md) | Fuel Type e.g. NUCLEAR | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData&gt;**](InsightsApiModelsResponsesGenerationDatasetRowsAugmentedOutturnData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsigcaget"></a>
# **DatasetsIGCAGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsIgcaDatasetRow DatasetsIGCAGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

Installed Generation Capacity Aggregated (IGCA / B1410)

This endpoint provides installed generation capacity aggregated data.    This API endpoint provides a maximum data output range of 2 years (731 days).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsIGCAGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-04-20T00:00:00Z;  // DateTime | 
            var publishDateTimeTo = 2022-04-27T00:00:00Z;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Installed Generation Capacity Aggregated (IGCA / B1410)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsIgcaDatasetRow result = apiInstance.DatasetsIGCAGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsIGCAGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsIGCAGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Installed Generation Capacity Aggregated (IGCA / B1410)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsIgcaDatasetRow> response = apiInstance.DatasetsIGCAGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsIGCAGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsIgcaDatasetRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsIgcaDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsigcastreamget"></a>
# **DatasetsIGCAStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsIgcaDatasetRow&gt; DatasetsIGCAStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

Installed Generation Capacity Aggregated (IGCA / B1410) stream

This endpoint provides installed generation capacity aggregated data.                This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsIGCAStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-04-20T00:00:00Z;  // DateTime | 
            var publishDateTimeTo = 2022-04-27T00:00:00Z;  // DateTime | 

            try
            {
                // Installed Generation Capacity Aggregated (IGCA / B1410) stream
                List<InsightsApiModelsResponsesTransparencyDatasetRowsIgcaDatasetRow> result = apiInstance.DatasetsIGCAStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsIGCAStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsIGCAStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Installed Generation Capacity Aggregated (IGCA / B1410) stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyDatasetRowsIgcaDatasetRow>> response = apiInstance.DatasetsIGCAStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsIGCAStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsIgcaDatasetRow&gt;**](InsightsApiModelsResponsesTransparencyDatasetRowsIgcaDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsimbalngcget"></a>
# **DatasetsIMBALNGCGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedImbalance DatasetsIMBALNGCGet (string? boundary = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Day and Day-Ahead Indicated Imbalance (IMBALNGC)

This endpoint provides the Indicated Imbalance. Data is received by daily by midday from NGESO.  Expressed as an average MW value for each Settlement period. The Indicated Imbalance forecast for  each period is the difference between the sum of the PNs submitted for generation BM Units (i.e.  the Indicated Generation), and the Transmission System Demand Forecast made by the System Operator.                This API endpoint provides a maximum data output range of 10 days

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsIMBALNGCGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var boundary = "boundary_example";  // string? |  (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Day and Day-Ahead Indicated Imbalance (IMBALNGC)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedImbalance result = apiInstance.DatasetsIMBALNGCGet(boundary, publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsIMBALNGCGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsIMBALNGCGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day and Day-Ahead Indicated Imbalance (IMBALNGC)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedImbalance> response = apiInstance.DatasetsIMBALNGCGetWithHttpInfo(boundary, publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsIMBALNGCGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **boundary** | **string?** |  | [optional]  |
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedImbalance**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedImbalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsimbalngcstreamget"></a>
# **DatasetsIMBALNGCStreamGet**
> List&lt;InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedImbalance&gt; DatasetsIMBALNGCStreamGet (string? boundary = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

Day and Day-Ahead Indicated Imbalance stream

This endpoint provides the Indicated Imbalance. Data is received by daily by midday from NGESO.  Expressed as an average MW value for each Settlement period. The Indicated Imbalance forecast for  each period is the difference between the sum of the PNs submitted for generation BM Units (i.e.  the Indicated Generation), and the National Demand Forecast made by the System Operator.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsIMBALNGCStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var boundary = "boundary_example";  // string? |  (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Day and Day-Ahead Indicated Imbalance stream
                List<InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedImbalance> result = apiInstance.DatasetsIMBALNGCStreamGet(boundary, publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsIMBALNGCStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsIMBALNGCStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day and Day-Ahead Indicated Imbalance stream
    ApiResponse<List<InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedImbalance>> response = apiInstance.DatasetsIMBALNGCStreamGetWithHttpInfo(boundary, publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsIMBALNGCStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **boundary** | **string?** |  | [optional]  |
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedImbalance&gt;**](InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedImbalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsinddemget"></a>
# **DatasetsINDDEMGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedDemand DatasetsINDDEMGet (string? boundary = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Day and Day-Ahead Indicated Demand (INDDEM)

This endpoint provides the indicated demand forecast for the current day and day-ahead received  from NGESO. The forecast is updated every half hour. The forecast for each period is the sum of  all the PNs submitted for BM Units which are forecast to be importing energy. Data is presented  an average MW for the Settlement Period.                This API endpoint provides a maximum data output range of 10 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsINDDEMGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var boundary = "boundary_example";  // string? |  (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Day and Day-Ahead Indicated Demand (INDDEM)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedDemand result = apiInstance.DatasetsINDDEMGet(boundary, publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsINDDEMGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsINDDEMGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day and Day-Ahead Indicated Demand (INDDEM)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedDemand> response = apiInstance.DatasetsINDDEMGetWithHttpInfo(boundary, publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsINDDEMGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **boundary** | **string?** |  | [optional]  |
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedDemand**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedDemand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsinddemstreamget"></a>
# **DatasetsINDDEMStreamGet**
> List&lt;InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedDemand&gt; DatasetsINDDEMStreamGet (string? boundary = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

Day and Day-Ahead Indicated Demand stream

This endpoint provides the indicated demand forecast for the current day and day-ahead received  from NGESO. The forecast is updated every half hour. The forecast for each period is the sum of  all the PNs submitted for BM Units which are forecast to be importing energy. Data is presented  an average MW for the Settlement Period.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsINDDEMStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var boundary = "boundary_example";  // string? |  (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Day and Day-Ahead Indicated Demand stream
                List<InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedDemand> result = apiInstance.DatasetsINDDEMStreamGet(boundary, publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsINDDEMStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsINDDEMStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day and Day-Ahead Indicated Demand stream
    ApiResponse<List<InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedDemand>> response = apiInstance.DatasetsINDDEMStreamGetWithHttpInfo(boundary, publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsINDDEMStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **boundary** | **string?** |  | [optional]  |
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedDemand&gt;**](InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedDemand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsindgenget"></a>
# **DatasetsINDGENGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedGeneration DatasetsINDGENGet (string? boundary = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Day and Day-Ahead Indicated Generation (INDGEN)

This endpoint provides the Indicated Generation received from NGESO. Data is received daily, by  midday. Expressed as an average MW value for each Settlement period. The Indicated Generation  forecast for each period is the sum of all the PNs submitted for BM Units which are forecast to  be exporting energy, presented as a single average MW value for the Settlement Period.    This API endpoint provides a maximum data output range of 10 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsINDGENGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var boundary = "boundary_example";  // string? |  (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Day and Day-Ahead Indicated Generation (INDGEN)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedGeneration result = apiInstance.DatasetsINDGENGet(boundary, publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsINDGENGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsINDGENGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day and Day-Ahead Indicated Generation (INDGEN)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedGeneration> response = apiInstance.DatasetsINDGENGetWithHttpInfo(boundary, publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsINDGENGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **boundary** | **string?** |  | [optional]  |
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedGeneration**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedGeneration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsindgenstreamget"></a>
# **DatasetsINDGENStreamGet**
> List&lt;InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedGeneration&gt; DatasetsINDGENStreamGet (string? boundary = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

Day and Day-Ahead Indicated Generation stream

This endpoint provides the Indicated Generation received from NGESO. Data is received daily, by  midday. Expressed as an average MW value for each Settlement period. The Indicated Generation  forecast for each period is the sum of all the PNs submitted for BM Units which are forecast to  be exporting energy, presented as a single average MW value for the Settlement Period.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsINDGENStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var boundary = "boundary_example";  // string? |  (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Day and Day-Ahead Indicated Generation stream
                List<InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedGeneration> result = apiInstance.DatasetsINDGENStreamGet(boundary, publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsINDGENStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsINDGENStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day and Day-Ahead Indicated Generation stream
    ApiResponse<List<InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedGeneration>> response = apiInstance.DatasetsINDGENStreamGetWithHttpInfo(boundary, publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsINDGENStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **boundary** | **string?** |  | [optional]  |
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedGeneration&gt;**](InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedGeneration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsindodget"></a>
# **DatasetsINDODGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandOutturnDatasetRowsIndodDatasetRow DatasetsINDODGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

Initial National Demand Outturn Daily (INDOD)

This endpoint provides initial National Demand outturn daily data. The total daily energy volume is the total  demand volume for the previous day expressed on an Initial National Demand Outturn (INDO) basis, i.e. excluding  station transformer, pumping and interconnector export demand. It is calculated from summing the half hourly  INDO demands (divided by two to convert to MWh).    This API endpoint has a maximum range of 2 years (731 days).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsINDODGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023-08-26T01:00:00Z;  // DateTime | 
            var publishDateTimeTo = 2023-08-27T01:00:00Z;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Initial National Demand Outturn Daily (INDOD)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandOutturnDatasetRowsIndodDatasetRow result = apiInstance.DatasetsINDODGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsINDODGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsINDODGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initial National Demand Outturn Daily (INDOD)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandOutturnDatasetRowsIndodDatasetRow> response = apiInstance.DatasetsINDODGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsINDODGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandOutturnDatasetRowsIndodDatasetRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandOutturnDatasetRowsIndodDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsindodstreamget"></a>
# **DatasetsINDODStreamGet**
> List&lt;InsightsApiModelsResponsesDemandOutturnDatasetRowsIndodDatasetRow&gt; DatasetsINDODStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

Initial National Demand Outturn Daily (INDOD) stream

This endpoint provides initial National Demand outturn daily data. The total daily energy volume is the total  demand volume for the previous day expressed on an Initial National Demand Outturn (INDO) basis, i.e. excluding  station transformer, pumping and interconnector export demand. It is calculated from summing the half hourly  INDO demands (divided by two to convert to MWh).    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsINDODStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023-08-26T01:00:00Z;  // DateTime | 
            var publishDateTimeTo = 2023-08-27T01:00:00Z;  // DateTime | 

            try
            {
                // Initial National Demand Outturn Daily (INDOD) stream
                List<InsightsApiModelsResponsesDemandOutturnDatasetRowsIndodDatasetRow> result = apiInstance.DatasetsINDODStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsINDODStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsINDODStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initial National Demand Outturn Daily (INDOD) stream
    ApiResponse<List<InsightsApiModelsResponsesDemandOutturnDatasetRowsIndodDatasetRow>> response = apiInstance.DatasetsINDODStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsINDODStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesDemandOutturnDatasetRowsIndodDatasetRow&gt;**](InsightsApiModelsResponsesDemandOutturnDatasetRowsIndodDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsindoget"></a>
# **DatasetsINDOGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandOutturnDatasetRowsDemandOutturnNational DatasetsINDOGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Initial National Demand Outturn data (INDO)

The endpoint provides data showing the initial National Demand outturn.  Data is updated at 15 min intervals containing the initial demand expressed in MW.                Specific publish time filters may be supplied, otherwise this will retrieve the latest published data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsINDOGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Initial National Demand Outturn data (INDO)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandOutturnDatasetRowsDemandOutturnNational result = apiInstance.DatasetsINDOGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsINDOGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsINDOGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initial National Demand Outturn data (INDO)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandOutturnDatasetRowsDemandOutturnNational> response = apiInstance.DatasetsINDOGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsINDOGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandOutturnDatasetRowsDemandOutturnNational**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandOutturnDatasetRowsDemandOutturnNational.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsitsdoget"></a>
# **DatasetsITSDOGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandOutturnDatasetRowsDemandOutturnTransmission DatasetsITSDOGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Initial Transmission System Outturn data (ITSDO)

The endpoint provides data showing the Transmission System Initial Demand outturn.  Data is updated at 15 min intervals containing the initial demand expressed in MW.                Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsITSDOGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Initial Transmission System Outturn data (ITSDO)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandOutturnDatasetRowsDemandOutturnTransmission result = apiInstance.DatasetsITSDOGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsITSDOGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsITSDOGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initial Transmission System Outturn data (ITSDO)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandOutturnDatasetRowsDemandOutturnTransmission> response = apiInstance.DatasetsITSDOGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsITSDOGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandOutturnDatasetRowsDemandOutturnTransmission**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandOutturnDatasetRowsDemandOutturnTransmission.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetslolpdrmget"></a>
# **DatasetsLOLPDRMGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsLossOfLoadProbabilityDeratedMarginData DatasetsLOLPDRMGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

Loss of Load Probability and De-rated Margin (LOLPDRM)

The Loss of Load Probability and De-rated Margin data is received half-hourly from NGESO.                Loss of Load Probability (LOLP) is a measure of system reliability, calculated by NGESO for each Settlement Period,  using the methodology set out in the Loss of Load Probability Calculation Statement.                De-rated Margin is a forecast of the excess supply on the system, which has been adjusted to take account of the likely availability of electricity generators.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsLOLPDRMGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023-03-06T07:00Z;  // DateTime | 
            var publishDateTimeTo = 2023-03-06T12:00Z;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Loss of Load Probability and De-rated Margin (LOLPDRM)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsLossOfLoadProbabilityDeratedMarginData result = apiInstance.DatasetsLOLPDRMGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsLOLPDRMGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsLOLPDRMGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Loss of Load Probability and De-rated Margin (LOLPDRM)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsLossOfLoadProbabilityDeratedMarginData> response = apiInstance.DatasetsLOLPDRMGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsLOLPDRMGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsLossOfLoadProbabilityDeratedMarginData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsLossOfLoadProbabilityDeratedMarginData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetslolpdrmstreamget"></a>
# **DatasetsLOLPDRMStreamGet**
> List&lt;InsightsApiModelsResponsesMiscDatasetRowsLossOfLoadProbabilityDeratedMarginData&gt; DatasetsLOLPDRMStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

Loss of Load Probability and De-rated Margin (LOLPDRM) stream

The Loss of Load Probability and De-rated Margin data is received half-hourly from NGESO.                Loss of Load Probability (LOLP) is a measure of system reliability, calculated by NGESO for each Settlement Period,  using the methodology set out in the Loss of Load Probability Calculation Statement.                De-rated Margin is a forecast of the excess supply on the system, which has been adjusted to take account of the likely availability of electricity generators.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsLOLPDRMStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023-03-06T07:00Z;  // DateTime | 
            var publishDateTimeTo = 2023-03-06T12:00Z;  // DateTime | 

            try
            {
                // Loss of Load Probability and De-rated Margin (LOLPDRM) stream
                List<InsightsApiModelsResponsesMiscDatasetRowsLossOfLoadProbabilityDeratedMarginData> result = apiInstance.DatasetsLOLPDRMStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsLOLPDRMStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsLOLPDRMStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Loss of Load Probability and De-rated Margin (LOLPDRM) stream
    ApiResponse<List<InsightsApiModelsResponsesMiscDatasetRowsLossOfLoadProbabilityDeratedMarginData>> response = apiInstance.DatasetsLOLPDRMStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsLOLPDRMStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesMiscDatasetRowsLossOfLoadProbabilityDeratedMarginData&gt;**](InsightsApiModelsResponsesMiscDatasetRowsLossOfLoadProbabilityDeratedMarginData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmatlget"></a>
# **DatasetsMATLGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsMonthAheadTotalLoadPerBiddingZoneDatasetRow DatasetsMATLGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

Month-Ahead Total Load Forecast Per Bidding Zone (MATL / B0640)

This endpoint provides month-ahead total load per bidding zone forecast data with minimum possible  and maximum available loads provided in MW values.    This API endpoint has a maximum range of 367 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMATLGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-06-25T00:00Z;  // DateTime | 
            var publishDateTimeTo = 2022-07-25T00:00Z;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Month-Ahead Total Load Forecast Per Bidding Zone (MATL / B0640)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsMonthAheadTotalLoadPerBiddingZoneDatasetRow result = apiInstance.DatasetsMATLGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMATLGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMATLGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Month-Ahead Total Load Forecast Per Bidding Zone (MATL / B0640)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsMonthAheadTotalLoadPerBiddingZoneDatasetRow> response = apiInstance.DatasetsMATLGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMATLGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsMonthAheadTotalLoadPerBiddingZoneDatasetRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsMonthAheadTotalLoadPerBiddingZoneDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmatlstreamget"></a>
# **DatasetsMATLStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsMonthAheadTotalLoadPerBiddingZoneDatasetRow&gt; DatasetsMATLStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

Month-Ahead Total Load Forecast Per Bidding Zone (MATL / B0640) stream

This endpoint provides month-ahead total load per bidding zone forecast data with minimum possible  and maximum available loads provided in MW values.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMATLStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-06-25T00:00Z;  // DateTime | 
            var publishDateTimeTo = 2022-07-25T00:00Z;  // DateTime | 

            try
            {
                // Month-Ahead Total Load Forecast Per Bidding Zone (MATL / B0640) stream
                List<InsightsApiModelsResponsesTransparencyDatasetRowsMonthAheadTotalLoadPerBiddingZoneDatasetRow> result = apiInstance.DatasetsMATLStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMATLStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMATLStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Month-Ahead Total Load Forecast Per Bidding Zone (MATL / B0640) stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyDatasetRowsMonthAheadTotalLoadPerBiddingZoneDatasetRow>> response = apiInstance.DatasetsMATLStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMATLStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsMonthAheadTotalLoadPerBiddingZoneDatasetRow&gt;**](InsightsApiModelsResponsesTransparencyDatasetRowsMonthAheadTotalLoadPerBiddingZoneDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmdpget"></a>
# **DatasetsMDPGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMaxData DatasetsMDPGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Maximum Delivery Period (MDP)

Maximum Delivery Period (MDP) is the maximum period, expressed in minutes, over which the  Maximum Delivery Volume (MDV) applies. Maximum Delivery Volume is the maximum number of MWh of Offer (or Bid)  that a particular BM Unit may deliver within the associated Maximum Delivery Period.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/MDP?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/MDP?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/MDP?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/MDP?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMDPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Maximum Delivery Period (MDP)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMaxData result = apiInstance.DatasetsMDPGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMDPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMDPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Maximum Delivery Period (MDP)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMaxData> response = apiInstance.DatasetsMDPGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMDPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMaxData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMaxData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmdpstreamget"></a>
# **DatasetsMDPStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMaxData&gt; DatasetsMDPStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Maximum Delivery Period Stream (MDP)

This endpoint provides Maximum Delivery Period data received from NGESO.                Maximum Delivery Period (MDP) is the maximum period over which the Maximum Delivery Volume (MDV) applies.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/MDP/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/MDP/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/MDP/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/MDP/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1    This endpoint has an optimised JSON payload and is aimed at frequent requests for MDP data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMDPStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Maximum Delivery Period Stream (MDP)
                List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMaxData> result = apiInstance.DatasetsMDPStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMDPStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMDPStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Maximum Delivery Period Stream (MDP)
    ApiResponse<List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMaxData>> response = apiInstance.DatasetsMDPStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMDPStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMaxData&gt;**](InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMaxData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmdvget"></a>
# **DatasetsMDVGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryVolumeMaxData DatasetsMDVGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Maximum Delivery Volume (MDV)

This endpoint provides Maximum Delivery Volume data received from NGESO.                Maximum Delivery Volume is the maximum number of MWh of Offer (or Bid), that a particular BM Unit  may deliver within the associated Maximum Delivery Period.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/MDV?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/MDV?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/MDV?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/MDV?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMDVGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Maximum Delivery Volume (MDV)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryVolumeMaxData result = apiInstance.DatasetsMDVGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMDVGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMDVGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Maximum Delivery Volume (MDV)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryVolumeMaxData> response = apiInstance.DatasetsMDVGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMDVGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryVolumeMaxData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryVolumeMaxData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmdvstreamget"></a>
# **DatasetsMDVStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryVolumeMaxData&gt; DatasetsMDVStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Maximum Delivery Volume Stream (MDV)

This endpoint provides Maximum Delivery Volume data received from NGESO.                Maximum Delivery Volume is the maximum number of MWh of Offer (or Bid), that a particular BM Unit  may deliver within the associated Maximum Delivery Period.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/MDV/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/MDV/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/MDV/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/MDV/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1    This endpoint has an optimised JSON payload and is aimed at frequent requests for MDV data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMDVStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Maximum Delivery Volume Stream (MDV)
                List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryVolumeMaxData> result = apiInstance.DatasetsMDVStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMDVStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMDVStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Maximum Delivery Volume Stream (MDV)
    ApiResponse<List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryVolumeMaxData>> response = apiInstance.DatasetsMDVStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMDVStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryVolumeMaxData&gt;**](InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryVolumeMaxData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmelngcget"></a>
# **DatasetsMELNGCGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedMargin DatasetsMELNGCGet (string? boundary = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Day and Day-Ahead Indicated Margin (MELNGC)

This endpoint provides the Indicated Margin. Data is received every half an hour from NGESO.  Expressed as an average MW value for each Settlement period. The Indicated Margin forecast for  each Settlement Period is the difference between the sum of the MELs submitted for that period,  and the National Demand Forecast made by the System Operator. The greater the value, the higher  the margin between available generation capacity and forecast demand - that is to say, the more  spare capacity there is forecast to be in the system.                This API endpoint provides a maximum data output range of 10 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMELNGCGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var boundary = "boundary_example";  // string? |  (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Day and Day-Ahead Indicated Margin (MELNGC)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedMargin result = apiInstance.DatasetsMELNGCGet(boundary, publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMELNGCGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMELNGCGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day and Day-Ahead Indicated Margin (MELNGC)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedMargin> response = apiInstance.DatasetsMELNGCGetWithHttpInfo(boundary, publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMELNGCGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **boundary** | **string?** |  | [optional]  |
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedMargin**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedMargin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmelngcstreamget"></a>
# **DatasetsMELNGCStreamGet**
> List&lt;InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedMargin&gt; DatasetsMELNGCStreamGet (string? boundary = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

Day and Day-Ahead Indicated Margin stream

This endpoint provides the Indicated Margin. Data is received every half an hour from NGESO.  Expressed as an average MW value for each Settlement period. The Indicated Margin forecast for  each Settlement Period is the difference between the sum of the MELs submitted for that period,  and the National Demand Forecast made by the System Operator. The greater the value, the higher  the margin between available generation capacity and forecast demand - that is to say, the more  spare capacity there is forecast to be in the system.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMELNGCStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var boundary = "boundary_example";  // string? |  (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Day and Day-Ahead Indicated Margin stream
                List<InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedMargin> result = apiInstance.DatasetsMELNGCStreamGet(boundary, publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMELNGCStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMELNGCStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day and Day-Ahead Indicated Margin stream
    ApiResponse<List<InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedMargin>> response = apiInstance.DatasetsMELNGCStreamGetWithHttpInfo(boundary, publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMELNGCStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **boundary** | **string?** |  | [optional]  |
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedMargin&gt;**](InsightsApiModelsResponsesIndicatedForecastDatasetRowsIndicatedMargin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmelsget"></a>
# **DatasetsMELSGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData DatasetsMELSGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Maximum Export Limit (MELS)

This endpoint provides Maximum Export Limit data received from NGESO.    The Maximum Export Limit is the maximum power export level of a particular BM Unit at a particular time.  The data is updated every 30 minutes and within 15 minutes of the end of the effective Settlement Period.  MELs are submitted as a series of MW values and associated times in UTC.    By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/mels?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/mels?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/mels?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/mels?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMELSGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-10-12T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-10-12T01:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Maximum Export Limit (MELS)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData result = apiInstance.DatasetsMELSGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMELSGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMELSGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Maximum Export Limit (MELS)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData> response = apiInstance.DatasetsMELSGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMELSGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmelsstreamget"></a>
# **DatasetsMELSStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData&gt; DatasetsMELSStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Maximum Export Limit Stream (MELS)

This endpoint provides Maximum Export Limit data received from NGESO.    The Maximum Export Limit is the maximum power export level of a particular BM Unit at a particular time.  The data is updated every 30 minutes and within 15 minutes of the end of the effective Settlement Period.  MELs are submitted as a series of MW values and associated times in UTC.    By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/mels/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/mels/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/mels/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/mels/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1  This endpoint has an optimised JSON payload and is aimed at frequent requests for MELS data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMELSStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-10-12T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-10-12T01:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Maximum Export Limit Stream (MELS)
                List<InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData> result = apiInstance.DatasetsMELSStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMELSStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMELSStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Maximum Export Limit Stream (MELS)
    ApiResponse<List<InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData>> response = apiInstance.DatasetsMELSStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMELSStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData&gt;**](InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmidget"></a>
# **DatasetsMIDGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsMarketIndexDatasetResponse DatasetsMIDGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? dataProviders = null, string? format = null)

Market Index Data (MID)

This endpoint provides Market Index Data received from NGESO.                Market Index Data is a key component in the calculation of System Buy Price and System Sell Price for each  Settlement Period. This data is received from each of the appointed Market Index Data Providers (MIDPs) and  reflects the price of wholesale electricity in Great Britain in the short term markets. The Market Index Data  which is received from each MIDP for each Settlement Period consists of a Market Index Volume and  Market Index Price, representing the volume and price of trading for the relevant period in the market operated  by the MIDP. The Market Price (the volume weighed average Market Index Price) is used to derive  the Reverse Price (SBP or SSP).\"                The two data providers available to query are N2EX (\"N2EXMIDP\") and APX (\"APXMIDP\").    By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/mid?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/mid?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/mid?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/mid?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMIDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-12T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-13T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var dataProviders = new List<string>?(); // List<string>? | The data providers to query. If no data provider is selected both will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Market Index Data (MID)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsMarketIndexDatasetResponse result = apiInstance.DatasetsMIDGet(from, to, settlementPeriodFrom, settlementPeriodTo, dataProviders, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Market Index Data (MID)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsMarketIndexDatasetResponse> response = apiInstance.DatasetsMIDGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, dataProviders, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **dataProviders** | [**List&lt;string&gt;?**](string.md) | The data providers to query. If no data provider is selected both will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsMarketIndexDatasetResponse**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsMarketIndexDatasetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmidstreamget"></a>
# **DatasetsMIDStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDatasetRowsMarketIndexDatasetResponse&gt; DatasetsMIDStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? dataProviders = null)

Market Index Data Stream (MID)

This endpoint provides Market Index Data received from NGESO.                Market Index Data is a key component in the calculation of System Buy Price and System Sell Price for each  Settlement Period. This data is received from each of the appointed Market Index Data Providers (MIDPs) and  reflects the price of wholesale electricity in Great Britain in the short term markets. The Market Index Data  which is received from each MIDP for each Settlement Period consists of a Market Index Volume and  Market Index Price, representing the volume and price of trading for the relevant period in the market operated  by the MIDP. The Market Price (the volume weighed average Market Index Price) is used to derive  the Reverse Price (SBP or SSP).\"                The two data providers available to query are N2EX (\"N2EXMIDP\") and APX (\"APXMIDP\").    By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/mid/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/mid/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/mid/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/mid/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1    This endpoint has an optimised JSON payload and is aimed at frequent requests for MID data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMIDStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-12T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-13T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var dataProviders = new List<string>?(); // List<string>? | The data providers to query. If no data provider is selected both will be displayed. (optional) 

            try
            {
                // Market Index Data Stream (MID)
                List<InsightsApiModelsResponsesBalancingDatasetRowsMarketIndexDatasetResponse> result = apiInstance.DatasetsMIDStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, dataProviders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMIDStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMIDStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Market Index Data Stream (MID)
    ApiResponse<List<InsightsApiModelsResponsesBalancingDatasetRowsMarketIndexDatasetResponse>> response = apiInstance.DatasetsMIDStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, dataProviders);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMIDStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **dataProviders** | [**List&lt;string&gt;?**](string.md) | The data providers to query. If no data provider is selected both will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDatasetRowsMarketIndexDatasetResponse&gt;**](InsightsApiModelsResponsesBalancingDatasetRowsMarketIndexDatasetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmilsget"></a>
# **DatasetsMILSGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData DatasetsMILSGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Maximum Import Limit (MILS)

This endpoint provides Maximum Import Limit data received from NGESO.    The maximum power import level of a particular BM Unit at a particular time.  The data is updated every 30 minutes and within 15 minutes of the end of the effective Settlement Period.  MILs are submitted as a series of MW values and associated times in UTC.    By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/mils?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/mils?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/mils?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/mils?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMILSGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-10-12T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-10-12T01:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Maximum Import Limit (MILS)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData result = apiInstance.DatasetsMILSGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMILSGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMILSGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Maximum Import Limit (MILS)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData> response = apiInstance.DatasetsMILSGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMILSGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmilsstreamget"></a>
# **DatasetsMILSStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData&gt; DatasetsMILSStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Maximum Import Limit Stream (MILS)

This endpoint provides Maximum Import Limit data received from NGESO.    The maximum power import level of a particular BM Unit at a particular time.  The data is updated every 30 minutes and within 15 minutes of the end of the effective Settlement Period.  MILs are submitted as a series of MW values and associated times in UTC.    By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/mils/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/mils/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/mils/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/mils/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1  This endpoint has an optimised JSON payload and is aimed at frequent requests for MILS data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMILSStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-10-12T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-10-12T01:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Maximum Import Limit Stream (MILS)
                List<InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData> result = apiInstance.DatasetsMILSStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMILSStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMILSStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Maximum Import Limit Stream (MILS)
    ApiResponse<List<InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData>> response = apiInstance.DatasetsMILSStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMILSStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData&gt;**](InsightsApiModelsResponsesBalancingPhysicalDatasetRowsDeliveryLimitMaxData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmnztget"></a>
# **DatasetsMNZTGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData DatasetsMNZTGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Minimum Non-Zero Time (MNZT)

This endpoint provides Minimum Non Zero Time data received from NGESO.    The Minimum Non-Zero Time represents the minimum time that a BM Unit can operate at a non-zero level as a result of a Bid-Offer Acceptance.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/MNZT?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/MNZT?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/MNZT?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/MNZT?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMNZTGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Minimum Non-Zero Time (MNZT)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData result = apiInstance.DatasetsMNZTGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMNZTGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMNZTGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Minimum Non-Zero Time (MNZT)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData> response = apiInstance.DatasetsMNZTGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMNZTGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmnztstreamget"></a>
# **DatasetsMNZTStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData&gt; DatasetsMNZTStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Minimum Non-Zero Time Stream (MNZT)

This endpoint provides Minimum Non Zero Time data received from NGESO.    The Minimum Non-Zero Time represents the minimum time that a BM Unit can operate at a non-zero level as a result of a Bid-Offer Acceptance.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/MNZT/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/MNZT/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/MNZT/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/MNZT/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1                This endpoint has an optimised JSON payload and is aimed at frequent requests for MNZT data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMNZTStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Minimum Non-Zero Time Stream (MNZT)
                List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData> result = apiInstance.DatasetsMNZTStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMNZTStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMNZTStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Minimum Non-Zero Time Stream (MNZT)
    ApiResponse<List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData>> response = apiInstance.DatasetsMNZTStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMNZTStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData&gt;**](InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmztget"></a>
# **DatasetsMZTGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData DatasetsMZTGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Minimum Zero Time (MZT)

This endpoint provides Minimum Zero Time data received from NGESO.    The Minimum Zero Time is the minimum time that a BM Unit which has been exporting must operate at zero or import, before returning to export;  whereas if the BM Unit has been importing, the MZT indicates the minimum time that it must operate at zero or export before returning to import,  if action by the System Operator (i.e. a Bid-Offer Acceptance) places it at such a level.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/MZT?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/MZT?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/MZT?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/MZT?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMZTGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Minimum Zero Time (MZT)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData result = apiInstance.DatasetsMZTGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMZTGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMZTGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Minimum Zero Time (MZT)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData> response = apiInstance.DatasetsMZTGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMZTGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmztstreamget"></a>
# **DatasetsMZTStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData&gt; DatasetsMZTStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Minimum Zero Time Stream (MZT)

This endpoint provides Minimum Zero Time data received from NGESO.    The Minimum Zero Time is the minimum time that a BM Unit which has been exporting must operate at zero or import, before returning to export;  whereas if the BM Unit has been importing, the MZT indicates the minimum time that it must operate at zero or export before returning to import,  if action by the System Operator (i.e. a Bid-Offer Acceptance) places it at such a level.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                  /// All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/MZT/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/MZT/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/MZT/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/MZT/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1    This endpoint has an optimised JSON payload and is aimed at frequent requests for MZT data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMZTStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Minimum Zero Time Stream (MZT)
                List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData> result = apiInstance.DatasetsMZTStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMZTStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMZTStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Minimum Zero Time Stream (MZT)
    ApiResponse<List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData>> response = apiInstance.DatasetsMZTStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMZTStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData&gt;**](InsightsApiModelsResponsesBalancingDynamicDatasetRowsDeliveryPeriodMinData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsmetadatalatestget"></a>
# **DatasetsMetadataLatestGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesReferenceDatasetMetadataLatestRow DatasetsMetadataLatestGet (string? format = null)

Returns the time when each dataset was last updated

Depending on the dataset, this value may be taken from the timestamp on the source datafile, the  publishTime field on the dataset, or the latest available measurement time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsMetadataLatestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Returns the time when each dataset was last updated
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesReferenceDatasetMetadataLatestRow result = apiInstance.DatasetsMetadataLatestGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsMetadataLatestGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsMetadataLatestGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the time when each dataset was last updated
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesReferenceDatasetMetadataLatestRow> response = apiInstance.DatasetsMetadataLatestGetWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsMetadataLatestGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesReferenceDatasetMetadataLatestRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesReferenceDatasetMetadataLatestRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsndfdget"></a>
# **DatasetsNDFDGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDaily DatasetsNDFDGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Demand and Surplus Forecast Data (2-14 days ahead) National Demand (NDFD)

This endpoint provides the National Demand forecast received from NGESO.  Data is available daily and will show values for the 2 to 14 days ahead.  Expressed as an average MW value for each Settlement period. The forecast is based on historically metered generation output for Great Britain.  This value INCLUDES transmission losses, but EXCLUDES Interconnector flows and demand from station.    This API endpoint provides a maximum data output range of 92 days.    Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNDFDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-14 days ahead) National Demand (NDFD)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDaily result = apiInstance.DatasetsNDFDGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNDFDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNDFDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-14 days ahead) National Demand (NDFD)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDaily> response = apiInstance.DatasetsNDFDGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNDFDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDaily**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDaily.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsndfdstreamget"></a>
# **DatasetsNDFDStreamGet**
> List&lt;InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDaily&gt; DatasetsNDFDStreamGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

Demand and Surplus Forecast Data (2-14 days ahead) National Demand (NDFD)

This endpoint provides the National Demand forecast received from NGESO.  Data is available daily and will show values for the 2 to 14 days ahead.  Expressed as an average MW value for each Settlement period. The forecast is based on historically metered generation output for Great Britain.  This value INCLUDES transmission losses, but EXCLUDES Interconnector flows and demand from station    Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the National Demand forecast data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNDFDStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-14 days ahead) National Demand (NDFD)
                List<InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDaily> result = apiInstance.DatasetsNDFDStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNDFDStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNDFDStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-14 days ahead) National Demand (NDFD)
    ApiResponse<List<InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDaily>> response = apiInstance.DatasetsNDFDStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNDFDStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDaily&gt;**](InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDaily.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsndfget"></a>
# **DatasetsNDFGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDayAhead DatasetsNDFGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

National Day and Day-Ahead National Demand Forecast (NDF)

This endpoint provides the National Demand forecast received from NGESO. Data is available  daily and will show values for the day ahead. Expressed as an average MW  value for each Settlement period. The forecast is based on historically metered generation  output for Great Britain. This value INCLUDES transmission losses, but EXCLUDES Interconnector  flows and demand from station transformers and pumped storage units.                This API endpoint provides a maximum data output range of 10 days.                Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNDFGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // National Day and Day-Ahead National Demand Forecast (NDF)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDayAhead result = apiInstance.DatasetsNDFGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNDFGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNDFGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // National Day and Day-Ahead National Demand Forecast (NDF)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDayAhead> response = apiInstance.DatasetsNDFGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNDFGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDayAhead**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDayAhead.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsndfstreamget"></a>
# **DatasetsNDFStreamGet**
> List&lt;InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDayAhead&gt; DatasetsNDFStreamGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

National Day and Day-Ahead National Demand Forecast stream

This endpoint provides the National Demand forecast received from NGESO. Data is available  daily and will show values for the day ahead. Expressed as an average MW  value for each Settlement period. The forecast is based on historically metered generation  output for Great Britain. This value INCLUDES transmission losses, but EXCLUDES Interconnector  flows and demand from station transformers and pumped storage units.                Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNDFStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // National Day and Day-Ahead National Demand Forecast stream
                List<InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDayAhead> result = apiInstance.DatasetsNDFStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNDFStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNDFStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // National Day and Day-Ahead National Demand Forecast stream
    ApiResponse<List<InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDayAhead>> response = apiInstance.DatasetsNDFStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNDFStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDayAhead&gt;**](InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalDayAhead.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsndfwget"></a>
# **DatasetsNDFWGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalWeekly DatasetsNDFWGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Demand and Surplus Forecast Data (2-52 weeks ahead) National Demand (NDFW)

This endpoint provides the National Demand forecast received from NGESO.  Data is available from 4pm each Thursday and will show values for the 2 to 52 weeks ahead.  Expressed as an average MW value for each week. The forecast is based on historically metered generation output for Great Britain.  This value INCLUDES transmission losses, but EXCLUDES Interconnector flows and demand from station.    This API endpoint provides a maximum data output range of 366 days.    Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNDFWGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-52 weeks ahead) National Demand (NDFW)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalWeekly result = apiInstance.DatasetsNDFWGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNDFWGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNDFWGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-52 weeks ahead) National Demand (NDFW)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalWeekly> response = apiInstance.DatasetsNDFWGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNDFWGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalWeekly**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalWeekly.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsndfwstreamget"></a>
# **DatasetsNDFWStreamGet**
> List&lt;InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalWeekly&gt; DatasetsNDFWStreamGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

Demand and Surplus Forecast Data (2-52 weeks ahead) National Demand (NDFW)

This endpoint provides the National Demand forecast received from NGESO.  Data is available from 4pm each Thursday and will show values for the 2 to 52 weeks ahead.  Expressed as an average MW value for each week. The forecast is based on historically metered generation output for Great Britain.  This value INCLUDES transmission losses, but EXCLUDES Interconnector flows and demand from station.    Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the National Demand forecast data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNDFWStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-52 weeks ahead) National Demand (NDFW)
                List<InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalWeekly> result = apiInstance.DatasetsNDFWStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNDFWStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNDFWStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-52 weeks ahead) National Demand (NDFW)
    ApiResponse<List<InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalWeekly>> response = apiInstance.DatasetsNDFWStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNDFWStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalWeekly&gt;**](InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastNationalWeekly.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsndzget"></a>
# **DatasetsNDZGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData DatasetsNDZGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Notice to Deviate from Zero (NDZ)

This endpoint provides Notice to Deviate from Zero data received from NGESO.                Notice to Deviate from Zero (NDZ) indicates the length of time required for a BM Unit to start importing or  exporting energy, from a zero Physical Notification level as a result of a Bid-Offer Acceptance, expressed in  minutes.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/NDZ?from=2022-06-01T00:00Z&to=2022-06-08T00:00Z                Filtering from start time to settlement date and period:                    /datasets/NDZ?from=2022-06-01T00:00Z&to=2022-06-08T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/NDZ?from=2022-06-01T00:00Z&to=2022-06-08T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/NDZ?from=2022-06-01T00:00Z&to=2022-06-08T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNDZGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Notice to Deviate from Zero (NDZ)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData result = apiInstance.DatasetsNDZGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNDZGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNDZGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Notice to Deviate from Zero (NDZ)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData> response = apiInstance.DatasetsNDZGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNDZGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsndzstreamget"></a>
# **DatasetsNDZStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData&gt; DatasetsNDZStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Notice to Deviate from Zero Stream (NDZ)

This endpoint provides Notice to Deviate from Zero data received from NGESO.                Notice to Deviate from Zero (NDZ) indicates the length of time required for a BM Unit to start importing or  exporting energy, from a zero Physical Notification level as a result of a Bid-Offer Acceptance, expressed in  minutes.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/NDZ/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/NDZ/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/NDZ/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/NDZ/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1    This endpoint has an optimised JSON payload and is aimed at frequent requests for NDZ data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNDZStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Notice to Deviate from Zero Stream (NDZ)
                List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData> result = apiInstance.DatasetsNDZStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNDZStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNDZStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Notice to Deviate from Zero Stream (NDZ)
    ApiResponse<List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData>> response = apiInstance.DatasetsNDZStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNDZStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData&gt;**](InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsnetbsadget"></a>
# **DatasetsNETBSADGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsNetBalancingServicesAdjustmentData DatasetsNETBSADGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, string? format = null)

Net Balancing Services Adjustment Data (NETBSAD)

This endpoint provides Net Balancing Services Adjustment data received from NGESO.                Net Balancing Services Adjustment data covers the buy/sell price, cost and volume adjustments for each  settlement period.                 By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/netbsad?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/netbsad?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/netbsad?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/netbsad?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNETBSADGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-10-10T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-10-17T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Net Balancing Services Adjustment Data (NETBSAD)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsNetBalancingServicesAdjustmentData result = apiInstance.DatasetsNETBSADGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNETBSADGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNETBSADGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Net Balancing Services Adjustment Data (NETBSAD)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsNetBalancingServicesAdjustmentData> response = apiInstance.DatasetsNETBSADGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNETBSADGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsNetBalancingServicesAdjustmentData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsNetBalancingServicesAdjustmentData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsnetbsadstreamget"></a>
# **DatasetsNETBSADStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDatasetRowsNetBalancingServicesAdjustmentData&gt; DatasetsNETBSADStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null)

Net Balancing Services Adjustment Data (NETBSAD)

This endpoint provides Net Balancing Services Adjustment data received from NGESO.                Net Balancing Services Adjustment data covers the buy/sell price, cost and volume adjustments for each  settlement period.                 By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/netbsad/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/netbsad/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/netbsad/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/netbsad/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1    This endpoint has an optimised JSON payload and is aimed at frequent requests for NETBSAD data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNETBSADStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-10-10T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-10-17T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 

            try
            {
                // Net Balancing Services Adjustment Data (NETBSAD)
                List<InsightsApiModelsResponsesBalancingDatasetRowsNetBalancingServicesAdjustmentData> result = apiInstance.DatasetsNETBSADStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNETBSADStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNETBSADStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Net Balancing Services Adjustment Data (NETBSAD)
    ApiResponse<List<InsightsApiModelsResponsesBalancingDatasetRowsNetBalancingServicesAdjustmentData>> response = apiInstance.DatasetsNETBSADStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNETBSADStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDatasetRowsNetBalancingServicesAdjustmentData&gt;**](InsightsApiModelsResponsesBalancingDatasetRowsNetBalancingServicesAdjustmentData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsnonbmget"></a>
# **DatasetsNONBMGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsNonBmStorData DatasetsNONBMGet (DateTime? from = null, DateTime? to = null, string? format = null)

Non-BM STOR (NONBM)

This endpoint provides data about the Short Term Operating Reserves (STOR) that have been made use of  by NGESO. This is activity that is outside of the Balancing Mechanism and takes place to meet the need to  increase generation or decrease demand.                To retrieve data from a particular time window, use the optional start and end time parameters.  These times should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.  If no time window is chosen, the default output will be the latest published data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNONBMGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-06-25T13:15Z;  // DateTime? | The start of the data publish time window. (optional) 
            var to = 2022-06-27T19:45Z;  // DateTime? | The end of the data publish time window. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Non-BM STOR (NONBM)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsNonBmStorData result = apiInstance.DatasetsNONBMGet(from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNONBMGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNONBMGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Non-BM STOR (NONBM)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsNonBmStorData> response = apiInstance.DatasetsNONBMGetWithHttpInfo(from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNONBMGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime?** | The start of the data publish time window. | [optional]  |
| **to** | **DateTime?** | The end of the data publish time window. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsNonBmStorData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsNonBmStorData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsnonbmstreamget"></a>
# **DatasetsNONBMStreamGet**
> List&lt;InsightsApiModelsResponsesGenerationDatasetRowsNonBmStorData&gt; DatasetsNONBMStreamGet (DateTime? from = null, DateTime? to = null)

Non-BM STOR (NONBM) stream

This endpoint provides data about the Short Term Operating Reserves (STOR) that have been made use of  by NGESO. This is activity that is outside of the Balancing Mechanism and takes place to meet the need to  increase generation or decrease demand.                To retrieve data from a particular time window, use the optional start and end time parameters.  These times should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.  If no time window is chosen, the default output will be the latest published data.                This endpoint has an optimised JSON payload and is aimed at frequent requests for the Non-BM STOR data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNONBMStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-06-25T13:15Z;  // DateTime? | The start of the data publish time window. (optional) 
            var to = 2022-06-27T19:45Z;  // DateTime? | The end of the data publish time window. (optional) 

            try
            {
                // Non-BM STOR (NONBM) stream
                List<InsightsApiModelsResponsesGenerationDatasetRowsNonBmStorData> result = apiInstance.DatasetsNONBMStreamGet(from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNONBMStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNONBMStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Non-BM STOR (NONBM) stream
    ApiResponse<List<InsightsApiModelsResponsesGenerationDatasetRowsNonBmStorData>> response = apiInstance.DatasetsNONBMStreamGetWithHttpInfo(from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNONBMStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime?** | The start of the data publish time window. | [optional]  |
| **to** | **DateTime?** | The end of the data publish time window. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesGenerationDatasetRowsNonBmStorData&gt;**](InsightsApiModelsResponsesGenerationDatasetRowsNonBmStorData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsnou2t14dget"></a>
# **DatasetsNOU2T14DGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityDaily DatasetsNOU2T14DGet (DateTime? publishDate = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

2 to 14 Days Ahead Generation availability aggregated data (NOU2T14D)

This endpoint provides a forward view of availability (also referred to as Output Usable data  under the Grid Code) for generation and interconnector capacity, accounting for planned outages  covering 2 days ahead to 14 days ahead. The data is aggregated at national level.                Date parameter must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNOU2T14DGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDate = 2022-09-20;  // DateTime? | The publish date for filtering. This must be in the format yyyy-MM-dd. (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // 2 to 14 Days Ahead Generation availability aggregated data (NOU2T14D)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityDaily result = apiInstance.DatasetsNOU2T14DGet(publishDate, publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNOU2T14DGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNOU2T14DGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 2 to 14 Days Ahead Generation availability aggregated data (NOU2T14D)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityDaily> response = apiInstance.DatasetsNOU2T14DGetWithHttpInfo(publishDate, publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNOU2T14DGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDate** | **DateTime?** | The publish date for filtering. This must be in the format yyyy-MM-dd. | [optional]  |
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityDaily**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityDaily.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsnou2t3ywget"></a>
# **DatasetsNOU2T3YWGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityWeekly DatasetsNOU2T3YWGet (DateTime? publishDate = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, List<int>? week = null, List<int>? year = null, string? format = null)

2 to 156 Weeks Ahead Generation availability aggregated data (NOU2T3YW)

This endpoint provides a forward view of availability (also referred to as Output Usable data  under the Grid Code) for generation and interconnector capacity, accounting for planned outages  covering availability data from 2 weeks ahead to 156 weeks ahead.  The data is an aggregation of all Fuel Type categories at national level.                Date parameter must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNOU2T3YWGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDate = 2022-09-20;  // DateTime? | The publish date for filtering. This must be in the format yyyy-MM-dd. (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var week = new List<int>?(); // List<int>? |  (optional) 
            var year = new List<int>?(); // List<int>? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // 2 to 156 Weeks Ahead Generation availability aggregated data (NOU2T3YW)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityWeekly result = apiInstance.DatasetsNOU2T3YWGet(publishDate, publishDateTimeFrom, publishDateTimeTo, week, year, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNOU2T3YWGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNOU2T3YWGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 2 to 156 Weeks Ahead Generation availability aggregated data (NOU2T3YW)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityWeekly> response = apiInstance.DatasetsNOU2T3YWGetWithHttpInfo(publishDate, publishDateTimeFrom, publishDateTimeTo, week, year, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNOU2T3YWGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDate** | **DateTime?** | The publish date for filtering. This must be in the format yyyy-MM-dd. | [optional]  |
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **week** | [**List&lt;int&gt;?**](int.md) |  | [optional]  |
| **year** | [**List&lt;int&gt;?**](int.md) |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityWeekly**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityWeekly.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsntbget"></a>
# **DatasetsNTBGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData DatasetsNTBGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Notice to Deliver Bids (NTB)

This endpoint provides Notice to Deliver Bids data received from NGESO.                Notice to Deliver Bids (NTB) indicates the length of time between the issuing of a Bid-Offer Acceptance and the  time when a BM Unit begins to deliver Bid volumes, expressed in minutes.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/NTB?from=2022-06-01T00:00Z&to=2022-06-08T00:00Z                Filtering from start time to settlement date and period:                    /datasets/NTB?from=2022-06-01T00:00Z&to=2022-06-08T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/NTB?from=2022-06-01T00:00Z&to=2022-06-08T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/NTB?from=2022-06-01T00:00Z&to=2022-06-08T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNTBGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Notice to Deliver Bids (NTB)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData result = apiInstance.DatasetsNTBGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNTBGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNTBGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Notice to Deliver Bids (NTB)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData> response = apiInstance.DatasetsNTBGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNTBGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsntbstreamget"></a>
# **DatasetsNTBStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData&gt; DatasetsNTBStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Notice to Deliver Bids Stream (NTB)

This endpoint provides Notice to Deliver Bids data received from NGESO.                Notice to Deliver Bids (NTB) indicates the length of time between the issuing of a Bid-Offer Acceptance and the  time when a BM Unit begins to deliver Bid volumes, expressed in minutes.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/NTB/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/NTB/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/NTB/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/NTB/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1    This endpoint has an optimised JSON payload and is aimed at frequent requests for NTB data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNTBStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Notice to Deliver Bids Stream (NTB)
                List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData> result = apiInstance.DatasetsNTBStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNTBStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNTBStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Notice to Deliver Bids Stream (NTB)
    ApiResponse<List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData>> response = apiInstance.DatasetsNTBStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNTBStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData&gt;**](InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsntoget"></a>
# **DatasetsNTOGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData DatasetsNTOGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Notice to Deliver Offers (NTO)

This endpoint provides Notice to Deliver Offers data received from NGESO.                Notice to Deliver Offers (NTO) indicates the length of time required for a BM Unit to start delivering Offers  from the time that the Bid-Offer Acceptance is issued, expressed in minutes.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/NTO?from=2022-06-01T00:00Z&to=2022-06-08T00:00Z                Filtering from start time to settlement date and period:                    /datasets/NTO?from=2022-06-01T00:00Z&to=2022-06-08T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/NTO?from=2022-06-01T00:00Z&to=2022-06-08T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/NTO?from=2022-06-01T00:00Z&to=2022-06-08T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNTOGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Notice to Deliver Offers (NTO)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData result = apiInstance.DatasetsNTOGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNTOGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNTOGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Notice to Deliver Offers (NTO)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData> response = apiInstance.DatasetsNTOGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNTOGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsntostreamget"></a>
# **DatasetsNTOStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData&gt; DatasetsNTOStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Notice to Deliver Offers Stream (NTO)

This endpoint provides Notice to Deliver Offers data received from NGESO.                Notice to Deliver Offers (NTO) indicates the length of time required for a BM Unit to start delivering Offers  from the time that the Bid-Offer Acceptance is issued, expressed in minutes.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/NTO/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/NTO/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/NTO/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/NTO/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1    This endpoint has an optimised JSON payload and is aimed at frequent requests for NTO data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsNTOStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Notice to Deliver Offers Stream (NTO)
                List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData> result = apiInstance.DatasetsNTOStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsNTOStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsNTOStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Notice to Deliver Offers Stream (NTO)
    ApiResponse<List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData>> response = apiInstance.DatasetsNTOStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsNTOStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData&gt;**](InsightsApiModelsResponsesBalancingDynamicDatasetRowsNoticeData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsocnmf3y2get"></a>
# **DatasetsOCNMF3Y2Get**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginWeekly DatasetsOCNMF3Y2Get (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Demand and Surplus Forecast Data (2-156 weeks ahead) Generating Plant Demand Margin (OCNMF3Y2)

The Demand and Surplus forecast surplus data is received hourly from NGESO.  It shows the daily peak half hour MW value of Generating Plant Demand Margin for each week for the 2 to 156 weeks ahead.                This API endpoint has a maximum data output range of 7 days.    Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsOCNMF3Y2GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-156 weeks ahead) Generating Plant Demand Margin (OCNMF3Y2)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginWeekly result = apiInstance.DatasetsOCNMF3Y2Get(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMF3Y2Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsOCNMF3Y2GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-156 weeks ahead) Generating Plant Demand Margin (OCNMF3Y2)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginWeekly> response = apiInstance.DatasetsOCNMF3Y2GetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMF3Y2GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginWeekly**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginWeekly.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsocnmf3y2streamget"></a>
# **DatasetsOCNMF3Y2StreamGet**
> List&lt;InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginWeekly&gt; DatasetsOCNMF3Y2StreamGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

Demand and Surplus Forecast Data (2-156 weeks ahead) Generating Plant Demand Margin (OCNMF3Y2) stream

The Demand and Surplus forecast surplus data is received hourly from NGESO.  It shows the daily peak half hour MW value of Generating Plant Demand Margin for each week for the 2 to 156 weeks ahead.    Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsOCNMF3Y2StreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-156 weeks ahead) Generating Plant Demand Margin (OCNMF3Y2) stream
                List<InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginWeekly> result = apiInstance.DatasetsOCNMF3Y2StreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMF3Y2StreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsOCNMF3Y2StreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-156 weeks ahead) Generating Plant Demand Margin (OCNMF3Y2) stream
    ApiResponse<List<InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginWeekly>> response = apiInstance.DatasetsOCNMF3Y2StreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMF3Y2StreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginWeekly&gt;**](InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginWeekly.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsocnmf3yget"></a>
# **DatasetsOCNMF3YGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusWeekly DatasetsOCNMF3YGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Demand and Surplus Forecast Data (2-156 weeks ahead) Surplus (OCNMF3Y)

The Demand and Surplus forecast surplus data is received hourly from NGESO.  It shows the daily weekly half hour MW value of Generating Plant Demand Surplus for each week for the 2 to 156 weeks ahead.    This API endpoint provides a maximum data output range of 7 days.                Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsOCNMF3YGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-156 weeks ahead) Surplus (OCNMF3Y)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusWeekly result = apiInstance.DatasetsOCNMF3YGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMF3YGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsOCNMF3YGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-156 weeks ahead) Surplus (OCNMF3Y)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusWeekly> response = apiInstance.DatasetsOCNMF3YGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMF3YGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusWeekly**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusWeekly.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsocnmf3ystreamget"></a>
# **DatasetsOCNMF3YStreamGet**
> List&lt;InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusWeekly&gt; DatasetsOCNMF3YStreamGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

Demand and Surplus Forecast Data (2-156 weeks ahead) Surplus (OCNMF3Y) stream

The Demand and Surplus forecast surplus data is received hourly from NGESO.  It shows the daily weekly half hour MW value of Generating Plant Demand Surplus for each week for the 2 to 156 weeks ahead.    Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the surplus forecast data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsOCNMF3YStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-156 weeks ahead) Surplus (OCNMF3Y) stream
                List<InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusWeekly> result = apiInstance.DatasetsOCNMF3YStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMF3YStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsOCNMF3YStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-156 weeks ahead) Surplus (OCNMF3Y) stream
    ApiResponse<List<InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusWeekly>> response = apiInstance.DatasetsOCNMF3YStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMF3YStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusWeekly&gt;**](InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusWeekly.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsocnmfd2get"></a>
# **DatasetsOCNMFD2Get**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginDaily DatasetsOCNMFD2Get (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Demand and Surplus Forecast Data (2-14 days ahead) Generating Plant Demand Margin (OCNMFD2)

The Demand and Surplus forecast demand margin data is received hourly from NGESO.  It shows the daily peak half hour MW value of Generating Plant Demand Surplus for each day for the 2 to 14 days ahead.    This API endpoint provides a maximum data output range of 7 days.                Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsOCNMFD2GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-14 days ahead) Generating Plant Demand Margin (OCNMFD2)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginDaily result = apiInstance.DatasetsOCNMFD2Get(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMFD2Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsOCNMFD2GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-14 days ahead) Generating Plant Demand Margin (OCNMFD2)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginDaily> response = apiInstance.DatasetsOCNMFD2GetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMFD2GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginDaily**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginDaily.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsocnmfd2streamget"></a>
# **DatasetsOCNMFD2StreamGet**
> List&lt;InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginDaily&gt; DatasetsOCNMFD2StreamGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

Demand and Surplus Forecast Data (2-14 days ahead) Generating Plant Demand Margin stream

The Demand and Surplus forecast demand margin data is received hourly from NGESO.  It shows the daily peak half hour MW value of Generating Plant Demand Surplus for each day for the 2 to 14 days ahead.    Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsOCNMFD2StreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-14 days ahead) Generating Plant Demand Margin stream
                List<InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginDaily> result = apiInstance.DatasetsOCNMFD2StreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMFD2StreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsOCNMFD2StreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-14 days ahead) Generating Plant Demand Margin stream
    ApiResponse<List<InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginDaily>> response = apiInstance.DatasetsOCNMFD2StreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMFD2StreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginDaily&gt;**](InsightsApiModelsResponsesForecastMarginDatasetRowsForecastMarginDaily.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsocnmfdget"></a>
# **DatasetsOCNMFDGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusDaily DatasetsOCNMFDGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Demand and Surplus Forecast Data (2-14 days ahead) Surplus (OCNMFD)

The Demand and Surplus forecast surplus data is received hourly from NGESO.  It shows the daily peak half hour MW value of Generating Plant Demand Surplus for each day for the 2 to 14 days ahead.    This API endpoint provides a maximum data output range of 7 days.                Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsOCNMFDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-14 days ahead) Surplus (OCNMFD)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusDaily result = apiInstance.DatasetsOCNMFDGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMFDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsOCNMFDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-14 days ahead) Surplus (OCNMFD)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusDaily> response = apiInstance.DatasetsOCNMFDGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMFDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusDaily**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusDaily.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsocnmfdstreamget"></a>
# **DatasetsOCNMFDStreamGet**
> List&lt;InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusDaily&gt; DatasetsOCNMFDStreamGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

Demand and Surplus Forecast Data (2-14 days ahead) Surplus stream

The Demand and Surplus forecast surplus data is received hourly from NGESO.  It shows the daily peak half hour MW value of Generating Plant Demand Surplus for each day for the 2 to 14 days ahead.    Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the surplus forecast data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsOCNMFDStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-14 days ahead) Surplus stream
                List<InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusDaily> result = apiInstance.DatasetsOCNMFDStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMFDStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsOCNMFDStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-14 days ahead) Surplus stream
    ApiResponse<List<InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusDaily>> response = apiInstance.DatasetsOCNMFDStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsOCNMFDStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusDaily&gt;**](InsightsApiModelsResponsesForecastSurplusDatasetRowsForecastSurplusDaily.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetspnget"></a>
# **DatasetsPNGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData DatasetsPNGet (DateTime settlementDate, int? settlementPeriod = null, List<string>? bmUnit = null, string? format = null)

Physical Notifications (PN)

This endpoint provides Physical Notification data received from NGESO. It returns the data valid for a single settlement period.  A Physical Notification is the best estimate of the level of generation or demand that a participant in the BM expects a BM Unit to export or import, respectively, in a Settlement Period.                Physical Notifications are submitted as a series of point MW values.                The settlement period to query can be specified as a date and settlement period, or as a datetime  which will resolve to the settlement period that time falls within.  If a settlement period is provided, it will take precedence over the time portion of the datetime.    Some examples of date parameter combinations are shown below.                Filtering by datetime:                     /datasets/PN?settlementDate=2022-07-01T01:00Z                Filtering by settlement date and period:                    /datasets/PN?settlementDate=2022-07-01&settlementPeriod=5

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsPNGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var settlementDate = 2022-07-01;  // DateTime | The settlement date or datetime to query.
            var settlementPeriod = 5;  // int? | The settlement period to query. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Physical Notifications (PN)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData result = apiInstance.DatasetsPNGet(settlementDate, settlementPeriod, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsPNGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsPNGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Physical Notifications (PN)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData> response = apiInstance.DatasetsPNGetWithHttpInfo(settlementDate, settlementPeriod, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsPNGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settlementDate** | **DateTime** | The settlement date or datetime to query. |  |
| **settlementPeriod** | **int?** | The settlement period to query. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetspnstreamget"></a>
# **DatasetsPNStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData&gt; DatasetsPNStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Physical Notifications Stream (PN)

This endpoint provides Physical Notification data received from NGESO.  A Physical Notification is the best estimate of the level of generation or demand that a participant in the BM expects a BM Unit to export or import, respectively, in a Settlement Period.                Physical Notifications are submitted as a series of point MW values.                The settlement period to query can be specified as a date and settlement period, or as a datetime  which will resolve to the settlement period that time falls within.  If a settlement period is provided, it will take precedence over the time portion of the datetime.    Some examples of date parameter combinations are shown below.                Filtering from settlement datetime to settlement datetime:                     /datasets/PN/stream?from=2022-07-01T00:00Z&to=2022-07-03T06:00Z                Filtering from settlement datetime to settlement date and period:                     /datasets/PN/stream?from=2022-07-01T00:00Z&to=2022-07-03&settlementPeriodTo=15                Filtering from settlement date and period to settlement datetime:                     /datasets/PN/stream?from=2022-07-01&settlementPeriodFrom=3&to=2022-07-03T06:00Z                Filtering from settlement date and period to settlement date and period:                    /datasets/PN/stream?from=2022-07-01&settlementPeriodFrom=3&to=2022-07-03&settlementPeriodTo=15    This endpoint has an optimised JSON payload and is aimed at frequent requests for PN data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsPNStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-07-01;  // DateTime | The settlement date to query from.
            var to = 2022-07-03;  // DateTime | The settlement date to query up to.
            var settlementPeriodFrom = 3;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 15;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Physical Notifications Stream (PN)
                List<InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData> result = apiInstance.DatasetsPNStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsPNStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsPNStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Physical Notifications Stream (PN)
    ApiResponse<List<InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData>> response = apiInstance.DatasetsPNStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsPNStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The settlement date to query from. |  |
| **to** | **DateTime** | The settlement date to query up to. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData&gt;**](InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsqasget"></a>
# **DatasetsQASGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData DatasetsQASGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Balancing Services Volume (QAS)

This endpoint provides Balancing Services Volume data received from NGESO.                Balancing Services Volume is a volume which is received from the System Operator, which represents the volume  of energy (MWh) associated with the provision of Applicable Balancing Services for each relevant BM Unit and  Settlement Period.    QAS can be positive or negative and is normally only provided where there is a non-zero volume.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/qas?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/qas?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/qas?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/qas?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsQASGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-12T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-13T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Balancing Services Volume (QAS)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData result = apiInstance.DatasetsQASGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsQASGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsQASGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Balancing Services Volume (QAS)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData> response = apiInstance.DatasetsQASGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsQASGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsqasstreamget"></a>
# **DatasetsQASStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData&gt; DatasetsQASStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Balancing Services Volume Stream (QAS)

This endpoint provides Balancing Services Volume data received from NGESO.                Balancing Services Volume is a volume which is received from the System Operator, which represents the volume  of energy (MWh) associated with the provision of Applicable Balancing Services for each relevant BM Unit and  Settlement Period.    QAS can be positive or negative and is normally only provided where there is a non-zero volume.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/qas/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/qas/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/qas/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/qas/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1    This endpoint has an optimised JSON payload and is aimed at frequent requests for QAS data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsQASStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-12T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-13T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Balancing Services Volume Stream (QAS)
                List<InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData> result = apiInstance.DatasetsQASStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsQASStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsQASStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Balancing Services Volume Stream (QAS)
    ApiResponse<List<InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData>> response = apiInstance.DatasetsQASStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsQASStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData&gt;**](InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsqpnget"></a>
# **DatasetsQPNGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData DatasetsQPNGet (DateTime settlementDate, int? settlementPeriod = null, List<string>? bmUnit = null, string? format = null)

Quiescent Physical Notifications (QPN)

This endpoint provides Quiescent Physical Notification data received from NGESO. It returns the data valid for a single settlement period.  Quiescent Physical Notifications describe the MW levels to be deducted from the Physical Notification of a BM Unit to determine a resultant operating level.                The settlement period to query can be specified as a date and settlement period, or as a datetime  which will resolve to the settlement period that time falls within.  If a settlement period is provided, it will take precedence over the time portion of the datetime.    Some examples of date parameter combinations are shown below.                Filtering by datetime:                     /datasets/QPN?settlementDate=2022-07-01T01:00Z                Filtering by settlement date and period:                    /datasets/QPN?settlementDate=2022-07-01&settlementPeriod=5

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsQPNGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var settlementDate = 2022-07-01;  // DateTime | The settlement date or datetime to query.
            var settlementPeriod = 5;  // int? | The settlement period to query. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Quiescent Physical Notifications (QPN)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData result = apiInstance.DatasetsQPNGet(settlementDate, settlementPeriod, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsQPNGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsQPNGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Quiescent Physical Notifications (QPN)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData> response = apiInstance.DatasetsQPNGetWithHttpInfo(settlementDate, settlementPeriod, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsQPNGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settlementDate** | **DateTime** | The settlement date or datetime to query. |  |
| **settlementPeriod** | **int?** | The settlement period to query. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsqpnstreamget"></a>
# **DatasetsQPNStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData&gt; DatasetsQPNStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Quiescent Physical Notifications Stream (QPN)

This endpoint provides Quiescent Physical Notification data received from NGESO.  Quiescent Physical Notifications describe the MW levels to be deducted from the Physical Notification of a BM Unit to determine a resultant operating level.                The settlement period to query can be specified as a date and settlement period, or as a datetime  which will resolve to the settlement period that time falls within.  If a settlement period is provided, it will take precedence over the time portion of the datetime.    Some examples of date parameter combinations are shown below.                Filtering from settlement datetime to settlement datetime:                     /datasets/QPN/stream?from=2022-07-01T00:00Z&to=2022-07-03T06:00Z                Filtering from settlement datetime to settlement date and period:                     /datasets/QPN/stream?from=2022-07-01T00:00Z&to=2022-07-03&settlementPeriodTo=15                Filtering from settlement date and period to settlement datetime:                     /datasets/QPN/stream?from=2022-07-01&settlementPeriodFrom=3&to=2022-07-03T06:00Z                Filtering from settlement date and period to settlement date and period:                    /datasets/QPN/stream?from=2022-07-01&settlementPeriodFrom=3&to=2022-07-03&settlementPeriodTo=15    This endpoint has an optimised JSON payload and is aimed at frequent requests for QPN data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsQPNStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-07-01;  // DateTime | The settlement date to query from.
            var to = 2022-07-03;  // DateTime | The settlement date to query up to.
            var settlementPeriodFrom = 3;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 15;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Quiescent Physical Notifications Stream (QPN)
                List<InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData> result = apiInstance.DatasetsQPNStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsQPNStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsQPNStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Quiescent Physical Notifications Stream (QPN)
    ApiResponse<List<InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData>> response = apiInstance.DatasetsQPNStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsQPNStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The settlement date to query from. |  |
| **to** | **DateTime** | The settlement date to query up to. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData&gt;**](InsightsApiModelsResponsesBalancingPhysicalDatasetRowsPhysicalNotificationData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsrdreget"></a>
# **DatasetsRDREGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData DatasetsRDREGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Run Down Rate Export (RDRE)

This endpoint provides Run Down Rate Export data received from NGESO.                Run Down Rate Export (RDRE) expresses the rate of decrease in active power production (MW/minute)  for a particular BM Unit which is exporting power within a particular operating range.   There can be up to three of these for a given BM Unit.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/rdre?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/rdre?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/rdre?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/rdre?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsRDREGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Run Down Rate Export (RDRE)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData result = apiInstance.DatasetsRDREGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsRDREGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsRDREGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Run Down Rate Export (RDRE)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData> response = apiInstance.DatasetsRDREGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsRDREGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsrdrestreamget"></a>
# **DatasetsRDREStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDynamicRateData&gt; DatasetsRDREStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Run Down Rate Export (RDRE) Stream

This endpoint provides Run Down Rate Export data received from NGESO.                Run Down Rate Export (RDRE) expresses the rate of decrease in active power production (MW/minute)  for a particular BM Unit which is exporting power within a particular operating range.   There can be up to three of these for a given BM Unit.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/rdre/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/rdre/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/rdre/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/rdre/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1    This endpoint has an optimised JSON payload and is aimed at frequent requests for QAS data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsRDREStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Run Down Rate Export (RDRE) Stream
                List<InsightsApiModelsResponsesBalancingDynamicRateData> result = apiInstance.DatasetsRDREStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsRDREStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsRDREStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Run Down Rate Export (RDRE) Stream
    ApiResponse<List<InsightsApiModelsResponsesBalancingDynamicRateData>> response = apiInstance.DatasetsRDREStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsRDREStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDynamicRateData&gt;**](InsightsApiModelsResponsesBalancingDynamicRateData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsrdriget"></a>
# **DatasetsRDRIGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData DatasetsRDRIGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Run Down Rate Import (RDRI)

This endpoint provides Run Down Rate Import data received from NGESO.                Run Down Rate Import (RDRI) expresses the rate of increase in active power consumption (MW/minute)  for a particular BM Unit which is importing power within a particular operating range.  There can be up to three of these for a given BM Unit.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/rdri?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/rdri?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/rdri?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/rdri?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsRDRIGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Run Down Rate Import (RDRI)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData result = apiInstance.DatasetsRDRIGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsRDRIGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsRDRIGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Run Down Rate Import (RDRI)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData> response = apiInstance.DatasetsRDRIGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsRDRIGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsrdristreamget"></a>
# **DatasetsRDRIStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDynamicRateData&gt; DatasetsRDRIStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Run Down Rate Import (RDRI) Stream

This endpoint provides Run Down Rate Import data received from NGESO.                Run Down Rate Import (RDRI) expresses the rate of increase in active power consumption (MW/minute)  for a particular BM Unit which is importing power within a particular operating range.   There can be up to three of these for a given BM Unit.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/rdri/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/rdri/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/rdri/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/rdri/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1    This endpoint has an optimised JSON payload and is aimed at frequent requests for QAS data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsRDRIStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Run Down Rate Import (RDRI) Stream
                List<InsightsApiModelsResponsesBalancingDynamicRateData> result = apiInstance.DatasetsRDRIStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsRDRIStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsRDRIStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Run Down Rate Import (RDRI) Stream
    ApiResponse<List<InsightsApiModelsResponsesBalancingDynamicRateData>> response = apiInstance.DatasetsRDRIStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsRDRIStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDynamicRateData&gt;**](InsightsApiModelsResponsesBalancingDynamicRateData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsremitget"></a>
# **DatasetsREMITGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyRemitDatasetRowsRemitMessage DatasetsREMITGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

The Regulation on Wholesale Energy Markets Integrity and Transparency (REMIT)

The Regulation on Wholesale Energy Markets Integrity and Transparency (REMIT) is an EU regulation aimed at preventing market abuse in wholesale energy markets.    This endpoint returns information provided by market participants to comply with Article 4 of Regulation on Wholesale Energy Market Integrity and Transparency (REMIT) Regulation (EU) 1227/2011.                Only JSON and XML formats are supported for this endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsREMITGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023/04/13 07:00;  // DateTime | 
            var publishDateTimeTo = 2023/04/13 10:00;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // The Regulation on Wholesale Energy Markets Integrity and Transparency (REMIT)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyRemitDatasetRowsRemitMessage result = apiInstance.DatasetsREMITGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsREMITGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsREMITGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The Regulation on Wholesale Energy Markets Integrity and Transparency (REMIT)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyRemitDatasetRowsRemitMessage> response = apiInstance.DatasetsREMITGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsREMITGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyRemitDatasetRowsRemitMessage**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyRemitDatasetRowsRemitMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsremitstreamget"></a>
# **DatasetsREMITStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyRemitDatasetRowsRemitMessage&gt; DatasetsREMITStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

The Regulation on Wholesale Energy Markets Integrity and Transparency (REMIT) stream

The Regulation on Wholesale Energy Markets Integrity and Transparency (REMIT) is an EU regulation aimed at preventing market abuse in wholesale energy markets.    This endpoint returns information provided by market participants to comply with Article 4 of Regulation on Wholesale Energy Market Integrity and Transparency (REMIT) Regulation (EU) 1227/2011.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsREMITStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023/04/13 07:00;  // DateTime | 
            var publishDateTimeTo = 2023/04/13 10:00;  // DateTime | 

            try
            {
                // The Regulation on Wholesale Energy Markets Integrity and Transparency (REMIT) stream
                List<InsightsApiModelsResponsesTransparencyRemitDatasetRowsRemitMessage> result = apiInstance.DatasetsREMITStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsREMITStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsREMITStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The Regulation on Wholesale Energy Markets Integrity and Transparency (REMIT) stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyRemitDatasetRowsRemitMessage>> response = apiInstance.DatasetsREMITStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsREMITStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyRemitDatasetRowsRemitMessage&gt;**](InsightsApiModelsResponsesTransparencyRemitDatasetRowsRemitMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsrureget"></a>
# **DatasetsRUREGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData DatasetsRUREGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Run Up Rate Export (RURE)

This endpoint provides Run Up Rate Export data received from NGESO.                Run Up Rate Export (RURE) expresses the rate of increase in active power production (MW/minute)  for a particular BM Unit which is exporting power within a particular operating range.  There can be up to three of these for a given BM Unit.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/rure?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/rure?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/rure?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/rure?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsRUREGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Run Up Rate Export (RURE)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData result = apiInstance.DatasetsRUREGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsRUREGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsRUREGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Run Up Rate Export (RURE)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData> response = apiInstance.DatasetsRUREGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsRUREGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsrurestreamget"></a>
# **DatasetsRUREStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDynamicRateData&gt; DatasetsRUREStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Run Up Rate Export (RURE) Stream

This endpoint provides Run Up Rate Export data received from NGESO.                Run Up Rate Export (RURE) expresses the rate of increase in active power production (MW/minute)  for a particular BM Unit which is exporting power within a particular operating range.  There can be up to three of these for a given BM Unit.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/rure/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/rure/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/rure/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/rure/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1    This endpoint has an optimised JSON payload and is aimed at frequent requests for QAS data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsRUREStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Run Up Rate Export (RURE) Stream
                List<InsightsApiModelsResponsesBalancingDynamicRateData> result = apiInstance.DatasetsRUREStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsRUREStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsRUREStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Run Up Rate Export (RURE) Stream
    ApiResponse<List<InsightsApiModelsResponsesBalancingDynamicRateData>> response = apiInstance.DatasetsRUREStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsRUREStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDynamicRateData&gt;**](InsightsApiModelsResponsesBalancingDynamicRateData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsruriget"></a>
# **DatasetsRURIGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData DatasetsRURIGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null, string? format = null)

Run Up Rate Import (RURI)

This endpoint provides Run Up Rate Import data received from NGESO.                Run Up Rate Import (RURI) expresses the rate of decrease in active power consumption (MW/minute)  for a particular BM Unit which is importing power within a particular operating range.  There can be up to three of these for a given BM Unit.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/ruri?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/ruri?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/ruri?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/ruri?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsRURIGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Run Up Rate Import (RURI)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData result = apiInstance.DatasetsRURIGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsRURIGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsRURIGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Run Up Rate Import (RURI)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData> response = apiInstance.DatasetsRURIGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsRURIGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicRateData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsruristreamget"></a>
# **DatasetsRURIStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDynamicRateData&gt; DatasetsRURIStreamGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? bmUnit = null)

Run Up Rate Import (RURI) Stream

This endpoint provides Run Up Rate Import data received from NGESO.                Run Up Rate Import (RURI) expresses the rate of decrease in active power consumption (MW/minute)  for a particular BM Unit which is importing power within a particular operating range.   There can be up to three of these for a given BM Unit.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /datasets/ruri/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /datasets/ruri/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /datasets/ruri/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /datasets/ruri/stream?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1    This endpoint has an optimised JSON payload and is aimed at frequent requests for QAS data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsRURIStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-08-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-08-02T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Run Up Rate Import (RURI) Stream
                List<InsightsApiModelsResponsesBalancingDynamicRateData> result = apiInstance.DatasetsRURIStreamGet(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsRURIStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsRURIStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Run Up Rate Import (RURI) Stream
    ApiResponse<List<InsightsApiModelsResponsesBalancingDynamicRateData>> response = apiInstance.DatasetsRURIStreamGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsRURIStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDynamicRateData&gt;**](InsightsApiModelsResponsesBalancingDynamicRateData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsselget"></a>
# **DatasetsSELGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData DatasetsSELGet (DateTime? from = null, DateTime? to = null, List<string>? bmUnit = null, string? format = null)

Stable Export Limit (SEL)

This endpoint provides Stable Export Limit data received from NGESO.  Stable Export Limit is a positive megawatt value, expressing the minimum stable operating level at which a particular BM Unit can export power to the transmission system.                If no date window is chosen, the search will default to results from last 24 hours.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsSELGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-07-20T13:15Z;  // DateTime? | The start of the data time window. (optional) 
            var to = 2022-07-21T13:15Z;  // DateTime? | The end of the data time window. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Stable Export Limit (SEL)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData result = apiInstance.DatasetsSELGet(from, to, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsSELGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsSELGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stable Export Limit (SEL)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData> response = apiInstance.DatasetsSELGetWithHttpInfo(from, to, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsSELGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime?** | The start of the data time window. | [optional]  |
| **to** | **DateTime?** | The end of the data time window. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsselstreamget"></a>
# **DatasetsSELStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData&gt; DatasetsSELStreamGet (DateTime? from = null, DateTime? to = null, List<string>? bmUnit = null)

Stable Export Limit Stream (SEL)

This endpoint provides Stable Export Limit data received from NGESO.  Stable Export Limit is a positive megawatt value, expressing the minimum stable operating level at which a particular BM Unit can export power to the transmission system.                If no date window is chosen, the search will default to results from last 24 hours.                This endpoint has an optimised JSON payload and is aimed at frequent requests for SEL data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsSELStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-07-20T13:15Z;  // DateTime? | The start of the data time window. (optional) 
            var to = 2022-07-21T13:15Z;  // DateTime? | The end of the data time window. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Stable Export Limit Stream (SEL)
                List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData> result = apiInstance.DatasetsSELStreamGet(from, to, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsSELStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsSELStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stable Export Limit Stream (SEL)
    ApiResponse<List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData>> response = apiInstance.DatasetsSELStreamGetWithHttpInfo(from, to, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsSELStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime?** | The start of the data time window. | [optional]  |
| **to** | **DateTime?** | The end of the data time window. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData&gt;**](InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetssilget"></a>
# **DatasetsSILGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData DatasetsSILGet (DateTime? from = null, DateTime? to = null, List<string>? bmUnit = null, string? format = null)

Stable Import Limit (SIL)

This endpoint provides Stable Import Limit data received from NGESO.  Stable Import Limit is a negative megawatt value, expressing the minimum stable operating level at which a particular BM Unit can import power from the transmission system.                If no date window is chosen, the search will default to results from last 24 hours.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsSILGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-07-20T13:15Z;  // DateTime? | The start of the data time window. (optional) 
            var to = 2022-07-21T13:15Z;  // DateTime? | The end of the data time window. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Stable Import Limit (SIL)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData result = apiInstance.DatasetsSILGet(from, to, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsSILGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsSILGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stable Import Limit (SIL)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData> response = apiInstance.DatasetsSILGetWithHttpInfo(from, to, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsSILGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime?** | The start of the data time window. | [optional]  |
| **to** | **DateTime?** | The end of the data time window. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetssilstreamget"></a>
# **DatasetsSILStreamGet**
> List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData&gt; DatasetsSILStreamGet (DateTime? from = null, DateTime? to = null, List<string>? bmUnit = null)

Stable Import Limit Stream (SIL)

This endpoint provides Stable Import Limit data received from NGESO.  Stable Import Limit is a negative megawatt value, expressing the minimum stable operating level at which a particular BM Unit can import power from the transmission system.                If no date window is chosen, the search will default to results from last 24 hours.                This endpoint has an optimised JSON payload and is aimed at frequent requests for SIL data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsSILStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var from = 2022-07-20T13:15Z;  // DateTime? | The start of the data time window. (optional) 
            var to = 2022-07-21T13:15Z;  // DateTime? | The end of the data time window. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. (optional) 

            try
            {
                // Stable Import Limit Stream (SIL)
                List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData> result = apiInstance.DatasetsSILStreamGet(from, to, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsSILStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsSILStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stable Import Limit Stream (SIL)
    ApiResponse<List<InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData>> response = apiInstance.DatasetsSILStreamGetWithHttpInfo(from, to, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsSILStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime?** | The start of the data time window. | [optional]  |
| **to** | **DateTime?** | The end of the data time window. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. If no BM unit is selected all BM units will be displayed. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData&gt;**](InsightsApiModelsResponsesBalancingDynamicDatasetRowsStablePortageLimitData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetssyswarnget"></a>
# **DatasetsSYSWARNGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsSystemWarningsData DatasetsSYSWARNGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

System Warnings (SYSWARN)

This endpoint provides system warnings data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsSYSWARNGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023/06/01 07:00;  // DateTime? |  (optional) 
            var publishDateTimeTo = 2023/06/30 10:00;  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // System Warnings (SYSWARN)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsSystemWarningsData result = apiInstance.DatasetsSYSWARNGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsSYSWARNGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsSYSWARNGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // System Warnings (SYSWARN)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsSystemWarningsData> response = apiInstance.DatasetsSYSWARNGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsSYSWARNGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsSystemWarningsData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsSystemWarningsData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetssyswarnstreamget"></a>
# **DatasetsSYSWARNStreamGet**
> List&lt;InsightsApiModelsResponsesMiscDatasetRowsSystemWarningsData&gt; DatasetsSYSWARNStreamGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

System Warnings (SYSWARN) stream

This endpoint provides system warnings data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsSYSWARNStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2023/06/01 07:00;  // DateTime? |  (optional) 
            var publishDateTimeTo = 2023/06/30 10:00;  // DateTime? |  (optional) 

            try
            {
                // System Warnings (SYSWARN) stream
                List<InsightsApiModelsResponsesMiscDatasetRowsSystemWarningsData> result = apiInstance.DatasetsSYSWARNStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsSYSWARNStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsSYSWARNStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // System Warnings (SYSWARN) stream
    ApiResponse<List<InsightsApiModelsResponsesMiscDatasetRowsSystemWarningsData>> response = apiInstance.DatasetsSYSWARNStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsSYSWARNStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesMiscDatasetRowsSystemWarningsData&gt;**](InsightsApiModelsResponsesMiscDatasetRowsSystemWarningsData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetstempget"></a>
# **DatasetsTEMPGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsTemperatureData DatasetsTEMPGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Temperature Data (TEMP)

This endpoint provides the average degree celsius value measured at midday deemed to be  representative of the temperature for Great Britain. Data is gathered from 6 weather stations.  Default output will be the last 31 days. Values are received from 5pm each day.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsTEMPGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Temperature Data (TEMP)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsTemperatureData result = apiInstance.DatasetsTEMPGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsTEMPGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsTEMPGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Temperature Data (TEMP)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsTemperatureData> response = apiInstance.DatasetsTEMPGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsTEMPGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsTemperatureData**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesMiscDatasetRowsTemperatureData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetstsdfdget"></a>
# **DatasetsTSDFDGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDaily DatasetsTSDFDGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Demand and Surplus Forecast Data (2-14 days ahead) Transmission System (TSDFD)

This end point provides the Transmission System forecast. Data is available daily and will show values for the 2 to 14 days ahead.  Expressed as an average MW value for each Settlement period. The Transmission System Demand Forecast is based on historically metered generation output for Great Britain.  This value INCLUDES Interconnector flows and demand from station transformers and pumped storage units.                Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.                This API endpoint provides a maximum data output range of 92 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsTSDFDGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-14 days ahead) Transmission System (TSDFD)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDaily result = apiInstance.DatasetsTSDFDGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsTSDFDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsTSDFDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-14 days ahead) Transmission System (TSDFD)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDaily> response = apiInstance.DatasetsTSDFDGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsTSDFDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDaily**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDaily.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetstsdfdstreamget"></a>
# **DatasetsTSDFDStreamGet**
> List&lt;InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDaily&gt; DatasetsTSDFDStreamGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

Demand and Surplus Forecast Data (2-14 days ahead) Transmission System (TSDFD) stream

This end point provides the Transmission System forecast. Data is available daily and will show values for the 2 to 14 days ahead.  Expressed as an average MW value for each Settlement period. The Transmission System Demand Forecast is based on historically metered generation output for Great Britain.  This value INCLUDES Interconnector flows and demand from station transformers and pumped storage units.                Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.                This endpoint has an optimised JSON payload and is aimed at frequent requests for the transmission system demand forecast data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsTSDFDStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-14 days ahead) Transmission System (TSDFD) stream
                List<InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDaily> result = apiInstance.DatasetsTSDFDStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsTSDFDStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsTSDFDStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-14 days ahead) Transmission System (TSDFD) stream
    ApiResponse<List<InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDaily>> response = apiInstance.DatasetsTSDFDStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsTSDFDStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDaily&gt;**](InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDaily.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetstsdfget"></a>
# **DatasetsTSDFGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDayAhead DatasetsTSDFGet (string? boundary = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Day and Day-Ahead Transmission System Demand Forecast (TSDF)

This endpoint provides the Transmission System forecast.  Data is received daily from NGESO and will show values for the day ahead.  Expressed as an average MW value for each Settlement period.  The Transmission System Demand Forecast is based on historically metered generation output for Great Britain.  This value INCLUDES Interconnector flows and demand from station transformers and pumped storage units.    Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsTSDFGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var boundary = "boundary_example";  // string? |  (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Day and Day-Ahead Transmission System Demand Forecast (TSDF)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDayAhead result = apiInstance.DatasetsTSDFGet(boundary, publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsTSDFGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsTSDFGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day and Day-Ahead Transmission System Demand Forecast (TSDF)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDayAhead> response = apiInstance.DatasetsTSDFGetWithHttpInfo(boundary, publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsTSDFGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **boundary** | **string?** |  | [optional]  |
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDayAhead**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDayAhead.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetstsdfstreamget"></a>
# **DatasetsTSDFStreamGet**
> List&lt;InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDayAhead&gt; DatasetsTSDFStreamGet (string? boundary = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

Day and Day-Ahead Transmission System Demand Forecast (TSDF)

This endpoint provides the Transmission System forecast.  Data is received daily from NGESO and will show values for the day ahead.  Expressed as an average MW value for each Settlement period.  The Transmission System Demand Forecast is based on historically metered generation output for Great Britain.  This value INCLUDES Interconnector flows and demand from station transformers and pumped storage units.    Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the transmission system demand forecast data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsTSDFStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var boundary = "boundary_example";  // string? |  (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Day and Day-Ahead Transmission System Demand Forecast (TSDF)
                List<InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDayAhead> result = apiInstance.DatasetsTSDFStreamGet(boundary, publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsTSDFStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsTSDFStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day and Day-Ahead Transmission System Demand Forecast (TSDF)
    ApiResponse<List<InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDayAhead>> response = apiInstance.DatasetsTSDFStreamGetWithHttpInfo(boundary, publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsTSDFStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **boundary** | **string?** |  | [optional]  |
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDayAhead&gt;**](InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionDayAhead.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetstsdfwget"></a>
# **DatasetsTSDFWGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionWeekly DatasetsTSDFWGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Demand and Surplus Forecast Data (2-52 weeks ahead) Transmission System Demand (TSDFW)

This endpoint provides the Transmission System Demand forecast received from NGESO.  Data is available from 4pm each Thursday and will show values for the 2 to 52 weeks ahead.  Expressed as an average MW value for each week. The forecast is based on historically metered generation output for Great Britain.  This value INCLUDES transmission losses, but EXCLUDES Interconnector flows and demand from station.    This API will provide a maximum data output range of 366 days.    Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsTSDFWGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-52 weeks ahead) Transmission System Demand (TSDFW)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionWeekly result = apiInstance.DatasetsTSDFWGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsTSDFWGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsTSDFWGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-52 weeks ahead) Transmission System Demand (TSDFW)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionWeekly> response = apiInstance.DatasetsTSDFWGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsTSDFWGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionWeekly**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionWeekly.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetstsdfwstreamget"></a>
# **DatasetsTSDFWStreamGet**
> List&lt;InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionWeekly&gt; DatasetsTSDFWStreamGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

Demand and Surplus Forecast Data (2-52 weeks ahead) Transmission System Demand (TSDFW)

This endpoint provides the Transmission System Demand forecast received from NGESO.  Data is available from 4pm each Thursday and will show values for the 2 to 52 weeks ahead.  Expressed as an average MW value for each week. The forecast is based on historically metered generation output for Great Britain.  This value INCLUDES transmission losses, but EXCLUDES Interconnector flows and demand from station.    Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the transmission system demand forecast data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsTSDFWStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Demand and Surplus Forecast Data (2-52 weeks ahead) Transmission System Demand (TSDFW)
                List<InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionWeekly> result = apiInstance.DatasetsTSDFWStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsTSDFWStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsTSDFWStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand and Surplus Forecast Data (2-52 weeks ahead) Transmission System Demand (TSDFW)
    ApiResponse<List<InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionWeekly>> response = apiInstance.DatasetsTSDFWStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsTSDFWStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionWeekly&gt;**](InsightsApiModelsResponsesDemandForecastDatasetRowsDemandForecastTransmissionWeekly.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsuou2t14dget"></a>
# **DatasetsUOU2T14DGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitDaily DatasetsUOU2T14DGet (List<string>? fuelType = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, List<string>? bmUnit = null, string? format = null)

2 to 14 Days Ahead Generation availability aggregated by Balancing Mechanism Units (UOU2T14D)

This endpoint provides a forward view of availability (also referred to as Output Usable  data under the Grid Code) for generation and interconnector capacity, accounting for planned  outages covering availability data from 2 days ahead to 14 days ahead; it is aggregated by  National Grid Balancing Mechanism Units (NGC BMUs).                In the context of this report, BMUs can be considered as generating units.  Elexon BMUs differs from NGC BMUs by including a prefix e.g. 'T_'.  The mapping between NGC and Elexon BMUs can be retrieved via reference data API endpoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsUOU2T14DGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var fuelType = new List<string>?(); // List<string>? | The fuel type to query. Add each fuel type separately. If no fuel types are supplied, all fuel types will be returned. (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Start of the Publish Time range to query. If specified, PublishDateTimeTo must also be specified.  If both are omitted, latest published data is returned. (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | End of the Publish Time range to query. If specified, PublishDateTimeFrom must also be specified.  If both are omitted, latest published data is returned. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. Either the Elexon ID or the National Grid ID can be used.  If no BM unit is supplied all BM units will be returned. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // 2 to 14 Days Ahead Generation availability aggregated by Balancing Mechanism Units (UOU2T14D)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitDaily result = apiInstance.DatasetsUOU2T14DGet(fuelType, publishDateTimeFrom, publishDateTimeTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsUOU2T14DGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsUOU2T14DGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 2 to 14 Days Ahead Generation availability aggregated by Balancing Mechanism Units (UOU2T14D)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitDaily> response = apiInstance.DatasetsUOU2T14DGetWithHttpInfo(fuelType, publishDateTimeFrom, publishDateTimeTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsUOU2T14DGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fuelType** | [**List&lt;string&gt;?**](string.md) | The fuel type to query. Add each fuel type separately. If no fuel types are supplied, all fuel types will be returned. | [optional]  |
| **publishDateTimeFrom** | **DateTime?** | Start of the Publish Time range to query. If specified, PublishDateTimeTo must also be specified.  If both are omitted, latest published data is returned. | [optional]  |
| **publishDateTimeTo** | **DateTime?** | End of the Publish Time range to query. If specified, PublishDateTimeFrom must also be specified.  If both are omitted, latest published data is returned. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. Either the Elexon ID or the National Grid ID can be used.  If no BM unit is supplied all BM units will be returned. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitDaily**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitDaily.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsuou2t14dstreamget"></a>
# **DatasetsUOU2T14DStreamGet**
> List&lt;InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitDaily&gt; DatasetsUOU2T14DStreamGet (List<string>? fuelType = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, List<string>? bmUnit = null)

2 to 14 Days Ahead Generation availability aggregated by Balancing Mechanism Units Stream (UOU2T14D)

This endpoint provides a forward view of availability (also referred to as Output Usable  data under the Grid Code) for generation and interconnector capacity, accounting for planned  outages covering availability data from 2 days ahead to 14 days ahead; it is aggregated by  National Grid Balancing Mechanism Units (NGC BMUs).                In the context of this report, BMUs can be considered as generating units.  Elexon BMUs differs from NGC BMUs by including a prefix e.g. 'T_'.  The mapping between NGC and Elexon BMUs can be retrieved via reference data API endpoints.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsUOU2T14DStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var fuelType = new List<string>?(); // List<string>? | The fuel type to query. Add each fuel type separately. If no fuel types are supplied, all fuel types will be returned. (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Start of the Publish Time range to query. If specified, PublishDateTimeTo must also be specified.  If both are omitted, latest published data is returned. (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | End of the Publish Time range to query. If specified, PublishDateTimeFrom must also be specified.  If both are omitted, latest published data is returned. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. Either the Elexon ID or the National Grid ID can be used.  If no BM unit is supplied all BM units will be returned. (optional) 

            try
            {
                // 2 to 14 Days Ahead Generation availability aggregated by Balancing Mechanism Units Stream (UOU2T14D)
                List<InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitDaily> result = apiInstance.DatasetsUOU2T14DStreamGet(fuelType, publishDateTimeFrom, publishDateTimeTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsUOU2T14DStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsUOU2T14DStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 2 to 14 Days Ahead Generation availability aggregated by Balancing Mechanism Units Stream (UOU2T14D)
    ApiResponse<List<InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitDaily>> response = apiInstance.DatasetsUOU2T14DStreamGetWithHttpInfo(fuelType, publishDateTimeFrom, publishDateTimeTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsUOU2T14DStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fuelType** | [**List&lt;string&gt;?**](string.md) | The fuel type to query. Add each fuel type separately. If no fuel types are supplied, all fuel types will be returned. | [optional]  |
| **publishDateTimeFrom** | **DateTime?** | Start of the Publish Time range to query. If specified, PublishDateTimeTo must also be specified.  If both are omitted, latest published data is returned. | [optional]  |
| **publishDateTimeTo** | **DateTime?** | End of the Publish Time range to query. If specified, PublishDateTimeFrom must also be specified.  If both are omitted, latest published data is returned. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. Either the Elexon ID or the National Grid ID can be used.  If no BM unit is supplied all BM units will be returned. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitDaily&gt;**](InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitDaily.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsuou2t3ywget"></a>
# **DatasetsUOU2T3YWGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitWeekly DatasetsUOU2T3YWGet (List<string>? fuelType = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, List<string>? bmUnit = null, string? format = null)

2 to 156 Weeks Ahead Generation availability aggregated by Balancing Mechanism Units (UOU2T3YW)

This endpoint forward view of availability (also referred to as Output Usable  data under the Grid Code) for generation and interconnector capacity, accounting for planned  outages covering availability data from 2 weeks ahead to 156 weeks ahead; it is aggregated by  Balancing Mechanism Units (BMUs).                In the context of this report, BMUs can be considered as generating units.  Elexon BMUs differs from NGC BMUs by including a prefix e.g. 'T_'.  The mapping between NGC and Elexon BMUs can be retrieved via reference data API endpoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsUOU2T3YWGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var fuelType = new List<string>?(); // List<string>? | The fuel type to query. Add each fuel type separately. If no fuel types are supplied, all fuel types will be returned. (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Start of the Publish Time range to query. If specified, PublishDateTimeTo must also be specified.  If both are omitted, latest published data is returned. (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | End of the Publish Time range to query. If specified, PublishDateTimeFrom must also be specified.  If both are omitted, latest published data is returned. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. Either the Elexon ID or the National Grid ID can be used.  If no BM unit is supplied all BM units will be returned. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // 2 to 156 Weeks Ahead Generation availability aggregated by Balancing Mechanism Units (UOU2T3YW)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitWeekly result = apiInstance.DatasetsUOU2T3YWGet(fuelType, publishDateTimeFrom, publishDateTimeTo, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsUOU2T3YWGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsUOU2T3YWGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 2 to 156 Weeks Ahead Generation availability aggregated by Balancing Mechanism Units (UOU2T3YW)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitWeekly> response = apiInstance.DatasetsUOU2T3YWGetWithHttpInfo(fuelType, publishDateTimeFrom, publishDateTimeTo, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsUOU2T3YWGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fuelType** | [**List&lt;string&gt;?**](string.md) | The fuel type to query. Add each fuel type separately. If no fuel types are supplied, all fuel types will be returned. | [optional]  |
| **publishDateTimeFrom** | **DateTime?** | Start of the Publish Time range to query. If specified, PublishDateTimeTo must also be specified.  If both are omitted, latest published data is returned. | [optional]  |
| **publishDateTimeTo** | **DateTime?** | End of the Publish Time range to query. If specified, PublishDateTimeFrom must also be specified.  If both are omitted, latest published data is returned. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. Either the Elexon ID or the National Grid ID can be used.  If no BM unit is supplied all BM units will be returned. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitWeekly**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitWeekly.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsuou2t3ywstreamget"></a>
# **DatasetsUOU2T3YWStreamGet**
> List&lt;InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitWeekly&gt; DatasetsUOU2T3YWStreamGet (List<string>? fuelType = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, List<string>? bmUnit = null)

2 to 156 Weeks Ahead Generation availability aggregated by Balancing Mechanism Units Stream (UOU2T3YW)

This endpoint forward view of availability (also referred to as Output Usable  data under the Grid Code) for generation and interconnector capacity, accounting for planned  outages covering availability data from 2 weeks ahead to 156 weeks ahead; it is aggregated by  Balancing Mechanism Units (BMUs).                In the context of this report, BMUs can be considered as generating units.  Elexon BMUs differs from NGC BMUs by including a prefix e.g. 'T_'.  The mapping between NGC and Elexon BMUs can be retrieved via reference data API endpoints.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsUOU2T3YWStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var fuelType = new List<string>?(); // List<string>? | The fuel type to query. Add each fuel type separately. If no fuel types are supplied, all fuel types will be returned. (optional) 
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Start of the Publish Time range to query. If specified, PublishDateTimeTo must also be specified.  If both are omitted, latest published data is returned. (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | End of the Publish Time range to query. If specified, PublishDateTimeFrom must also be specified.  If both are omitted, latest published data is returned. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM units to query. Add each unit separately. Either the Elexon ID or the National Grid ID can be used.  If no BM unit is supplied all BM units will be returned. (optional) 

            try
            {
                // 2 to 156 Weeks Ahead Generation availability aggregated by Balancing Mechanism Units Stream (UOU2T3YW)
                List<InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitWeekly> result = apiInstance.DatasetsUOU2T3YWStreamGet(fuelType, publishDateTimeFrom, publishDateTimeTo, bmUnit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsUOU2T3YWStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsUOU2T3YWStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 2 to 156 Weeks Ahead Generation availability aggregated by Balancing Mechanism Units Stream (UOU2T3YW)
    ApiResponse<List<InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitWeekly>> response = apiInstance.DatasetsUOU2T3YWStreamGetWithHttpInfo(fuelType, publishDateTimeFrom, publishDateTimeTo, bmUnit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsUOU2T3YWStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fuelType** | [**List&lt;string&gt;?**](string.md) | The fuel type to query. Add each fuel type separately. If no fuel types are supplied, all fuel types will be returned. | [optional]  |
| **publishDateTimeFrom** | **DateTime?** | Start of the Publish Time range to query. If specified, PublishDateTimeTo must also be specified.  If both are omitted, latest published data is returned. | [optional]  |
| **publishDateTimeTo** | **DateTime?** | End of the Publish Time range to query. If specified, PublishDateTimeFrom must also be specified.  If both are omitted, latest published data is returned. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM units to query. Add each unit separately. Either the Elexon ID or the National Grid ID can be used.  If no BM unit is supplied all BM units will be returned. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitWeekly&gt;**](InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityByBmUnitWeekly.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetswatlget"></a>
# **DatasetsWATLGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow DatasetsWATLGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630)

This endpoint provides week-ahead total load forecast per bidding zone data with minimum possible  and maximum available loads provided in MW values.    This API endpoint has a maximum range of 367 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsWATLGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-06-25T00:00Z;  // DateTime | 
            var publishDateTimeTo = 2022-07-25T00:00Z;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow result = apiInstance.DatasetsWATLGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsWATLGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsWATLGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow> response = apiInstance.DatasetsWATLGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsWATLGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetswatlstreamget"></a>
# **DatasetsWATLStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow&gt; DatasetsWATLStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630) stream

This endpoint provides week-ahead total load forecast per bidding zone data with minimum possible  and maximum available loads provided in MW values.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsWATLStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-06-25T00:00Z;  // DateTime | 
            var publishDateTimeTo = 2022-07-25T00:00Z;  // DateTime | 

            try
            {
                // Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630) stream
                List<InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow> result = apiInstance.DatasetsWATLStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsWATLStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsWATLStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630) stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow>> response = apiInstance.DatasetsWATLStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsWATLStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow&gt;**](InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetswindforget"></a>
# **DatasetsWINDFORGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast DatasetsWINDFORGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

Wind Generation Forecast (WINDFOR)

This endpoint provides wind generation forecast data.    Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsWINDFORGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Wind Generation Forecast (WINDFOR)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast result = apiInstance.DatasetsWINDFORGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsWINDFORGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsWINDFORGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wind Generation Forecast (WINDFOR)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast> response = apiInstance.DatasetsWINDFORGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsWINDFORGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetswindforstreamget"></a>
# **DatasetsWINDFORStreamGet**
> List&lt;InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast&gt; DatasetsWINDFORStreamGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null)

Wind Generation Forecast (WINDFOR)

This endpoint provides wind generation forecast data.    Specific publish time filters may be supplied, otherwise this will retrieve the latest published forecast.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the wind generation forecast data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsWINDFORStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Wind Generation Forecast (WINDFOR)
                List<InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast> result = apiInstance.DatasetsWINDFORStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsWINDFORStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsWINDFORStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Wind Generation Forecast (WINDFOR)
    ApiResponse<List<InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast>> response = apiInstance.DatasetsWINDFORStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsWINDFORStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast&gt;**](InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsyafmget"></a>
# **DatasetsYAFMGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadForecastMarginDatasetRow DatasetsYAFMGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

Year Ahead Forecast Margin (YAFM / B0810)

This endpoint provides year-ahead forecast margin data.                A year-ahead forecast margin is defined as the difference between yearly forecast of available generation capacity and yearly forecast of total load,  taking into account the forecast of total generation capacity, forecast of availability of generation and forecast of reserves contracted for system services.    This API endpoint has a maximum range of 20 years (7305 days).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsYAFMGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2021-06-01T00:00Z;  // DateTime | 
            var publishDateTimeTo = 2022-07-25T00:00Z;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Year Ahead Forecast Margin (YAFM / B0810)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadForecastMarginDatasetRow result = apiInstance.DatasetsYAFMGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsYAFMGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsYAFMGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Year Ahead Forecast Margin (YAFM / B0810)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadForecastMarginDatasetRow> response = apiInstance.DatasetsYAFMGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsYAFMGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadForecastMarginDatasetRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadForecastMarginDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsyafmstreamget"></a>
# **DatasetsYAFMStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadForecastMarginDatasetRow&gt; DatasetsYAFMStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

Year Ahead Forecast Margin (YAFM / B0810)

This endpoint provides year-ahead forecast margin data.    A year-ahead forecast margin is defined as the difference between yearly forecast of available generation capacity and yearly forecast of total load,  taking into account the forecast of total generation capacity, forecast of availability of generation and forecast of reserves contracted for system services.                This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsYAFMStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2021-06-01T00:00Z;  // DateTime | 
            var publishDateTimeTo = 2022-07-25T00:00Z;  // DateTime | 

            try
            {
                // Year Ahead Forecast Margin (YAFM / B0810)
                List<InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadForecastMarginDatasetRow> result = apiInstance.DatasetsYAFMStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsYAFMStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsYAFMStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Year Ahead Forecast Margin (YAFM / B0810)
    ApiResponse<List<InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadForecastMarginDatasetRow>> response = apiInstance.DatasetsYAFMStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsYAFMStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadForecastMarginDatasetRow&gt;**](InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadForecastMarginDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsyatlget"></a>
# **DatasetsYATLGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadTotalLoadPerBiddingZoneDatasetRow DatasetsYATLGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo, string? format = null)

Year-Ahead Total Load Forecast Per Bidding Zone (YATL / B0650)

This endpoint provides year-ahead total load per bidding zone forecast data with minimum possible  and maximum available loads provided in MW values.    This API endpoint has a maximum range of 367 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsYATLGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-06-25T00:00Z;  // DateTime | 
            var publishDateTimeTo = 2022-07-25T00:00Z;  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Year-Ahead Total Load Forecast Per Bidding Zone (YATL / B0650)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadTotalLoadPerBiddingZoneDatasetRow result = apiInstance.DatasetsYATLGet(publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsYATLGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsYATLGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Year-Ahead Total Load Forecast Per Bidding Zone (YATL / B0650)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadTotalLoadPerBiddingZoneDatasetRow> response = apiInstance.DatasetsYATLGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsYATLGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadTotalLoadPerBiddingZoneDatasetRow**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadTotalLoadPerBiddingZoneDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasetsyatlstreamget"></a>
# **DatasetsYATLStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadTotalLoadPerBiddingZoneDatasetRow&gt; DatasetsYATLStreamGet (DateTime publishDateTimeFrom, DateTime publishDateTimeTo)

Year-Ahead Total Load Forecast Per Bidding Zone (YATL / B0650) stream

This endpoint provides year-ahead total load per bidding zone forecast data with minimum possible  and maximum available loads provided in MW values.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DatasetsYATLStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DatasetsApi(config);
            var publishDateTimeFrom = 2022-06-25T00:00Z;  // DateTime | 
            var publishDateTimeTo = 2022-07-25T00:00Z;  // DateTime | 

            try
            {
                // Year-Ahead Total Load Forecast Per Bidding Zone (YATL / B0650) stream
                List<InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadTotalLoadPerBiddingZoneDatasetRow> result = apiInstance.DatasetsYATLStreamGet(publishDateTimeFrom, publishDateTimeTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.DatasetsYATLStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DatasetsYATLStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Year-Ahead Total Load Forecast Per Bidding Zone (YATL / B0650) stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadTotalLoadPerBiddingZoneDatasetRow>> response = apiInstance.DatasetsYATLStreamGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.DatasetsYATLStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime** |  |  |
| **publishDateTimeTo** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadTotalLoadPerBiddingZoneDatasetRow&gt;**](InsightsApiModelsResponsesTransparencyDatasetRowsYearAheadTotalLoadPerBiddingZoneDatasetRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

