// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;


const string fullStr = "UpdatedDate,CreatedDate,CreatedBy,UpdatedBy,ObjectId, EpisodeDate,  DataVersion, PrintedDate,AccessionedDate,IsOpened,Verified,IsBlockSectioned,IsTransient,Source,ItemState,CreatedFromPanel,IsConflicted,HasPrintedChildren,Status,StatusUpdateTime,CaseInternalId,IsPrinted,PathologistId,NumPages,DisplayItemState,ProcessDescriptionId,Id,IsPending,IsShownInUI";

var unused = Regex.Replace(fullStr, "\\s+", "");
