# AndroidGameView with async / await compatability on a dedicated thread

##Overview
OpenTK is a set of bindings to OpenGL, OpenCL and OpenAL. This is not the main repository, it extendes OpenTK for Android to work with a dedicated rendering execution context. To do so, we used a specific looper (BackgroundLooper) that extends SynchronizationContext class.
It is important to note that SynchronizationContext is the fundamental component of the async / await patern. For details, you can check [Parallel Programming with .Net - ExecutionContext vs SynchronizationContext](http://blogs.msdn.com/b/pfxteam/archive/2012/06/15/executioncontext-vs-synchronizationcontext.aspx)  
When the Activity is Paused or Stopped surface and window are destroyed and to prevent loosing OpenGL context, AndroidGameView detaches it from the window and Surface (for details, please, look at this [discussion](http://forums.xamarin.com/discussion/621/androidgameview-pause-without-losing-gl-context/p2).  
To guarantee that no OpenGL calls are made when the Activity is Paused or Stopped, we created an interface (IExecutionContext) with method Pause to stop the execution of the looper and Resume to reinitialize the execution of queued methods. This interface is used by AndroidGameView and Rendering_ExecutionContext_Android is an implementation that we provide that essentially do a set of other things on top of BackgroundLooper. 

Note : in this implementation we do not provide any timer to periodically call OnRenderFrame like it happens with Run method

##How to use

1 - Create a normal OpenGL Application from the template provided by Xamarin Studio

2 - Replace OpenTk by a version compiled with the code available in this repository

3 - Change the creation of GLView1 (AndroidGameView child) to something like


    public class MainActivity : Activity
	  {
		  GLView1 view;
		  //To gurantee that the looper is always alive
		  static Rendering_ExecutionContext_Android rendering_ExecutionContext = new Rendering_ExecutionContext_Android();
    
		  protected override void OnCreate (Bundle bundle)
		  {
			  base.OnCreate (bundle);


			  //Starts the looper
			  if(rendering_ExecutionContext.State != ExecutionState.Executing)
			  	rendering_ExecutionContext.Start ();

			  view = new GLView1 (this);
			  view.RenderingExecutionContext = rendering_ExecutionContext;

			
			  SetContentView (view);

	    }
    }
		
4 - Remove the call to Run in OnLoad overridden method
		
5 - To Execute on Rendering thread 
		
		rendering_ExecutionContext.BeginInvoke(new Action(async()=>{
				await ...
			}), null);
			
			rendering_ExecutionContext.BeginInvoke(new Action(()=>{
				
			}), null);

