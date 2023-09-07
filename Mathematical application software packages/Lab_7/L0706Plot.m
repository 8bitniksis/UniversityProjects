%M-file 'anim.m' for Free Pendulum animation:
function [sys,x0]=L0706Plot(t,x,u,flag,par_ts,x0,y0);
  global PendAnim
  global handle
  global x y % length of Pendulum  
  % update model: sys = mdlUpdate(t,x,u,par_ts)
  if flag==2,      
      %if get(0,'Children')== 1, % test, if plot exists
          set(0,'currentfigure',PendAnim);
          % delete previous image (mode 'xor')
          plot(x,y,'.','MarkerSize',30,...
          'EraseMode','xor');
          
          axis([0 30 0 30]); %axis properties
          % Current coordinates of Pendulum
          % [u(2)*sin(u(1)),-u(2)*cos(u(1))]
          x = u(1);
          y = u(2);          
          % Draw the current position of Pendulum          
          set(handle,'XData',x,'YData',y);          
          drawnow; % update plot
      %end
      sys=[];
  elseif flag == 4 % Return next sample hit
      % sys = mdlGetTimeOfNextVarHit(t,x,u,par_ts)
      sys = t + par_ts; % the constant sample interval
  elseif flag==0, %[sys,x0,str,ts]=mdlInitializeSizes;
      % Initialize the figure for use with this simulation
      [PendAnim, par2] = animinit('Pendulum Animation');      
      axis([0 30 0 30]); % axis properties
      hold on            
      % Draw the current position of Pendulum
      x=x0; y=y0;
      % plot the Pendulum and init setting
      handle=plot(x,y,'EraseMode','xor','LineWidth',5);      
      % Set the relative scaling of
      % the individual axis data values
      set(gca,'DataAspectRatio',[1 1 1]);
      sys=[0 0 0 2 0 0]; % 2 - number of inputs
      x0 = []; % No continuous states
  end;