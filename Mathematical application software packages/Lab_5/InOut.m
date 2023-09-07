% create data
clear;
tend = 20;
t = [0:0.01:tend]';
u = 2 * sin(3 * t);

% run simulink-model
SimRes = sim('Primer0511.mdl', [0, tend]);

% plot results
h = plot(SimRes.tout, SimRes.yout); 
set(h, 'linewidth', 2);
grid on;
