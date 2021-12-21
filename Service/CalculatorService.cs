using System.Collections.Generic;
using System.Threading.Tasks;

namespace VolumeWeb.Service
{
    public interface CalculatorService
    {
        public Task<VolumeResult> CalculateVolumeCylinderAsync(double height, double radius);
        public Task<VolumeResult> CalculateVolumeConeAsync(double height, double radius);

        public Task<List<VolumeResult>> GetAllAsync();
    }
}