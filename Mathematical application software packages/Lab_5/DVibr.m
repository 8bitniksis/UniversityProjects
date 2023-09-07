% create data
clear;
F = 0.05;
T = 50;
tend = 300;
t = [0:0.005:tend]';

% run simulink-model
Sig = sim('DampedVibr2.mdl', [0, tend]);

h = plot(Sig.Data.time, Sig.Data.signals.values);
set(h, 'linewidth', 2);
h2 = title('Damped Vibration');
ylabel('Amplitude', 'fontsize', 12);
xlabel('Time[s]', 'fontsize', 12);
h3 = legend('Vibration', 'upper envelope curve', 'lower envelope curve');
set ([h2, h3, gca], 'fontsize', 12);
grid on;