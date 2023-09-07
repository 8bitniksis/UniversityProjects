% initial values
xInitial=[1 1];
t=[0:0.01:15]';
u=exp(-t);


% run simulink-model
SimRes = sim('L0506.mdl');


% plot results
h = plot(SimRes.tout, SimRes.yout.signals.values);
set(h, 'linewidth', 2);
h2 = title('Вынужденные колебания маятника');
ylabel('Y', 'fontsize', 12);
xlabel('время[с]', 'fontsize', 12);
h3 = legend('Значение угла phi', 'Управляющий сигнал');
set ([h2, h3, gca], 'fontsize', 12);
grid on;

