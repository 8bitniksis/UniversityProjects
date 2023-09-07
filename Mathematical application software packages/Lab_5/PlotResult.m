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