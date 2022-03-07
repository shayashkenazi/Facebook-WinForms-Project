using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public static class FormFeatureFactory
    {
        public static FormFeature Create(User iUser, eFeature iContext)
        {
            FormFeature result = null;
            
            switch (iContext)
            {
                case eFeature.TriviaFeature:
                    result = new TriviaForm(iUser);
                   
                    break;
                case eFeature.CreateCommonGroups:
                    result = new CreateCommonGroupsForm();
                  break;
            }

            if (result != null)
            {
                result.User = iUser;
            }

            return result;
        }
    }
}
