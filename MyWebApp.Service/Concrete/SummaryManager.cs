using AutoMapper;
using MyWebApp.Data.Abstract;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.SummaryDtos;
using MyWebApp.Service.Abstract;
using MyWebApp.Shared.Utilities.Abstract;
using MyWebApp.Shared.Utilities.ComplexTypes;
using MyWebApp.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Service.Concrete
{
    public class SummaryManager : ISummaryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SummaryManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> Delete(int summaryId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<SummaryDto>> Get(int summaryId = 1)
        {
            var summary = await _unitOfWork.Summary.GetAsync(x => x.Id == summaryId);
            if (summary != null)
            {
                return new DataResult<SummaryDto>(ResultStatus.Success, new SummaryDto
                {
                    ResultStatus = ResultStatus.Success,
                    Summary = summary
                });
            }
            return new DataResult<SummaryDto>(ResultStatus.Error, "Hata, kayıt bulunamadı!", new SummaryDto
            {
                ResultStatus = ResultStatus.Error,
                Summary = null,
                Message = "Hata, kayıt bulunamadı!"
            });
        }

        public async Task<IDataResult<SummaryUpdateDto>> GetUpdateDto(int summaryId)
        {
            var summary = await _unitOfWork.Summary.GetAsync(x => x.Id == summaryId);
            if (summary != null)
            {
                var summaryUpdateDto = _mapper.Map<SummaryUpdateDto>(summary);
                return new DataResult<SummaryUpdateDto>(ResultStatus.Success,summaryUpdateDto);
            }
            return new DataResult<SummaryUpdateDto>(ResultStatus.Error,"Hata, kayıt bulunamadı!",null);
        }

        public async Task<IResult> HardDelete(int summaryId)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<SummaryDto>> Update(SummaryUpdateDto summaryUpdateDto, string modifiedByName)
        {
            var summary = _mapper.Map<Summary>(summaryUpdateDto);
            summary.ModifiedByName = modifiedByName;
            var updatedSummary = await _unitOfWork.Summary.UpdateAsync(summary);
            await _unitOfWork.SaveAsync();
            return new DataResult<SummaryDto>(ResultStatus.Success, "Özet başarılı bir şekilde güncellenmiştir.", new SummaryDto
            {
                ResultStatus = ResultStatus.Success,
                Message = "Özet başarılı bir şekilde güncellenmiştir.",
                Summary = updatedSummary
            });
        }
    }
}
