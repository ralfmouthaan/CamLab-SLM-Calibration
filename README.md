# CamLab-SLM-Calibration

## Binary Grating Calibration
Some code for SLM calibrations. This creates a binary grating, and one of the grayscale values while monitoring the power in the first order using a camera. The camera has to have been set up using CamLab-OffAxisCamera-Setup to crop out just the first order, although off-axis interferometry is not used here, and so the FFT crop is not important. Processing of the data is subsequently done in Matlab.

## Other Calibrations
The binary grating calibration makes certain assumptions that I do not think hold. For example, it is assumed the SLM is completely flat. I intend to implement other, better calibrations at some point.
