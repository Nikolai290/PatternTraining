using System;
using System.Threading.Tasks;

namespace PatternTraining.CarDrivingSimulate {
    public class ScreenRenderer {

        public int FrameTime { get; private set; }

        public ScreenRenderer(
            int frameTime
            ) {
            FrameTime = frameTime;
        }

        public async Task Render(ScreenData data) {
            Console.Clear();
            data.Show();
            await Task.Delay(FrameTime);
        }
    }
}
