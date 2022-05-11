% Ralf Mouthaan
% University of Cambridge
% December 2021
%
% Script to process SLM grating calibration data

clc; clear variables; close all;

%%

NoRepeats = 5;
Phase = linspace(0, 2*pi, 51);
Power = zeros(size(Phase));

for ii = 1:length(Phase)
    
    for jj = 1:NoRepeats
        fname = sprintf('Grating Cal - %0.2f rad - #%d.png', Phase(ii), jj);
        Img = imread(fname);
        Img = Img(410:500,770:860);
        Power(ii) = sum(sum(Img))/NoRepeats;
    end
    
end

figure;
plot(Phase, Power, 'LineWidth', 2);
xlabel('Phase Difference (rad.)');
ylabel('Power in First Order');
set(gca, 'FontSize', 14);
title('Jasper @ 633nm');

xline(pi/2, ':', 'LineWidth', 2);
xline(pi, ':', 'LineWidth', 2);
xline(3*pi/2, ':', 'LineWidth', 2);