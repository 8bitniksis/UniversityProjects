clear all;
m = 1000;               % Mass of car (kg)
v = 20;                 % Velocity of car (m/s)
%k = 500;                % Stiffness of spring (kg/s^2)
k = input('Spring stiffness (50-5000 kg/s^2) k = ');
c = input('Damping parameter (10-1000 kg/s) c = ');
%c = 100;                % Damping coefficient (kg/s)
hole_start = 100;       % Horizontal displacement before
                        % the tire enters the hole (m)
hole_length = 1;        % Length of hole (m)
hole_depth = 0.15;      % Depth of hole (m)
t1 = hole_start / v;    % Time of which the tire enters the hole (s)
t2 = (hole_start + hole_length) / v; % the tire comes out of the hole (s)

sim('L0507.mdl');
load in.mat             % Load input displacement (in)
load res.mat            % Load result displacement (res)
figure(1)
%subplot(2,1,1); plot(in(1,:), in(2,:));
subplot(2,1,1); plot(in.time, in.data);
xlabel('t, sek');
ylabel('y1, m');
title(sprintf('Spring-Mass-Damper Dynamic System: k = %d c = %d', k, c));
%subplot(2,1,2); plot(res(1,:), res(2,:));
subplot(2,1,2); plot(res.time, res.data)
xlabel('t, sek');
ylabel('h, m');