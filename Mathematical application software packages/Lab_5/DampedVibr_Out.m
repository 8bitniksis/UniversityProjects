h = plot(out.Data.time, out.Data.signals.values);
set(h, 'linewidth', 2);
h2 = title('Damped Vibration');
ylabel('Amplitude', 'fontsize', 12);
xlabel('Time[s]', 'fontsize', 12);
h3 = legend('Vibration', 'upper envelope curve', 'lower envelope curve');
set ([h2, h3, gca], 'fontsize', 12);
grid on;