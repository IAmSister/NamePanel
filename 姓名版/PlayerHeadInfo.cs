using UnityEngine;
using System.Collections;
using GCGame.Table;
using GCGame;


public class PlayerHeadInfo : MonoBehaviour
{

    public UILabel m_LabelTitleBoard;
    public UISprite m_SprVip;
    public UILabel m_LabelName;
    public UISprite m_GuildBusinessState;
    public GameObject m_ObjChatBubble;
    public GameObject m_ObjOriginalHeadInfo;

    public GameObject l_ObjDropItemPop;
    public GameObject l_ObjDropGrid;


    public GameObject m_ZiDongGuaJi;
    public GameObject m_ZiDongXunLu;


    public void ToggleXunLu(bool b)
    {

        if (m_ZiDongGuaJi.activeSelf && b)
            ToggleGuaJi(!b);
        this.m_ZiDongXunLu.SetActive(b);
    }
    public void ToggleGuaJi(bool b)
    {
        if (!m_ZiDongXunLu.activeSelf)
        {
            m_ZiDongGuaJi.SetActive(b);
        }
    }
    //����VIP��ʾ
    public void UpdateVipInfo(int nVipCost)
    {
        
    }

    public void UpdateGuildBusinessIcon(int iconState)
    {
        if (m_GuildBusinessState == null)
        {
            return;
        }
        switch (iconState)
        {
            case 1:
                m_GuildBusinessState.gameObject.SetActive(true);
                m_GuildBusinessState.spriteName = "ShangNon";
                m_GuildBusinessState.MakePixelPerfect();
                break;

            case 2:
                m_GuildBusinessState.gameObject.SetActive(true);
                m_GuildBusinessState.spriteName = "ShangOk";
                m_GuildBusinessState.MakePixelPerfect();
                break;

            default:
                m_GuildBusinessState.gameObject.SetActive(false);
                break;
        }
    }

    public void ShowTitleInvestitiveByTable(int titleID, string strTitleInvestitive)
    {
        //���ݱ���id������ ���и�ֵ  
        //û��text��Ϊ��
       
        
    }

   /// <summary>
   /// չʾͷ�Ϲҵ�
   /// </summary>
   /// <param name="itemId"></param>
    public void ShowDropPop(int itemId)
    {
        if (null != l_ObjDropItemPop)
        {
        		
            //����������
            //����  �����ø��� ��ת λ�� ��С ��������ʾ
        
        }
    }

    public void ShowTitleInvestitive(string strTitleInvestitive)
    {
        m_LabelTitleBoard.text = strTitleInvestitive;
    }

    public void ShowOriginalHeadInfo(bool bShow)
    {
        if (null != m_ObjOriginalHeadInfo)
        {
            m_ObjOriginalHeadInfo.SetActive(bShow);
        }
    }

    public void ShowChatBubble()
    {
        //������Ϣչʾ
    }
}
