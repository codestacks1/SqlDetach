# SqlDetach
<h4>从代码中剥离SQL，提供高效维护SQL和简单处理SQL条件的方法</h4>
<div>
    <p>摆脱频繁的数据库操作代码，使你的代码更清晰可读！ 很高兴与您分享迷人的SQLDetach架构</p>
    <p>该架构使用事件驱动的MVC架构，让你的结果数据更明朗可查</p>
</div>
<div class="content projectdesc">
    <p>框架简介：</p>
    <p style="margin-left:20px;color:blue;">Xiaowen.SqlDetach.SQL</p>
    <p style="margin-left:20px;">主要包含SQL文本，及SQL中使用的where、group by、order by等子句的处理器</p>
    <p style="margin-left:20px;"></p>
    <p style="margin-left:20px;color:blue;">Xiaowen.SqlDetach.Basic</p>
    <p style="margin-left:20px;">定义了全局使用的事件及SQL文本委托</p>
    <p style="margin-left:20px;color:blue;">Xiaowen.SqlDetach.DAL</p>
    <p style="margin-left:20px;">数据库访问层，包含演示<em>Code</em></p>
    <p style="margin-left:20px;color:blue;">Xiaowen.SqlDetach.BLL</p>
    <p style="margin-left:20px;">业务逻辑层，包含演示Code</p>
    <p style="margin-left:20px;color:blue;">Xiaowen.SqlDetach.MvcWebDemo</p>
    <p style="margin-left:20px;">MVC架构Web站点，包含前端处理UI交互条件及事件的演示Code</p>
</div>
<br/>
<div>
<p>
*修改条件处理器方法，增加isSpecialHandler，即该条件是否需要特殊处理具体，具体使用方法后期维护写入Demo
</p>
<code>
<pre>
/// <summary>
/// 条件处理器
///     快速、统一处理查询条件
/// </summary>
/// <param name="dataParameter"></param>
/// <param name="param">此处有约束，前两个参数一定只允许是日期或时间</param>
/// <returns></returns>
private static StringBuilder WhereConditionHandler(ref ArrayList dataParameter, params WhereClauseSchema[] param)
{
    StringBuilder where = new StringBuilder();
    DataParameter beingDate = null;

    if (param != null)
        foreach (WhereClauseSchema item in param)
        {
            if (item.IsExistFlag == true)
            {
                if (item.IsSingleDate != null)
                {
                    if (item.IsSingleDate == true)
                    {
                        if (item.Content != null)
                        {
                            if (item.IsSpecialHandler == true)
                            {
                                where.AppendFormat(" AND {0}={1}", item.Condition, "@" + item.PrimaryKey);
                                dataParameter.Add(new DataParameter("@" + item.PrimaryKey, item.Content));
                            }
                            else
                            {
                                where.AppendFormat(" AND {0}={1}", item.Condition, "@" + item.Condition);
                                dataParameter.Add(new DataParameter("@" + item.Condition, item.Content));
                            }
                        }
                    }
                    else
                    {
                        if (item.Content != null)
                        {
                            if (beingDate == null)
                            {
                                beingDate = new DataParameter("@" + item.PrimaryKey, item.Content);
                                where.AppendFormat(" AND {0}>={1}", item.Condition, "@" + item.PrimaryKey);
                                dataParameter.Add(new DataParameter("@" + item.PrimaryKey, item.Content));
                            }
                            else
                            {
                                where.AppendFormat(" AND {0}<={1}", item.Condition, "@End" + item.PrimaryKey);
                                dataParameter.Add(new DataParameter("@End" + item.PrimaryKey, item.Content));
                            }
                        }
                    }
                }
                else
                {
                    where.AppendFormat(" AND {0}={1}", item.Condition, "@" + item.Condition);
                    dataParameter.Add(new DataParameter("@" + item.Condition, item.Content));
                }
            }
            else

                if (item.IsSingleDate != null)
                {
                    if (item.IsSingleDate == true)
                    {
                        if (item.Content != null)
                        {
                            where.AppendFormat(" AND {0}={1}", item.Condition, "@" + item.Condition);
                            dataParameter.Add(new DataParameter("@" + item.Condition, item.Content));
                        }
                    }
                    else
                    {
                        if (item.Content != null)
                        {
                            if (beingDate == null)
                            {
                                beingDate = new DataParameter("@" + item.PrimaryKey, item.Content);
                                where.AppendFormat(" AND {0}>={1}", item.Condition, "@" + item.PrimaryKey);
                                dataParameter.Add(beingDate);
                            }
                            else
                            {
                                where.AppendFormat(" AND {0}<={1}", item.Condition, "@End" + item.PrimaryKey);
                                dataParameter.Add(new DataParameter("@End" + item.PrimaryKey, item.Content));
                            }
                        }
                    }
                }
                else
                {
                    where.AppendFormat(" AND {0}={1}", item.Condition, "@" + item.Condition);
                    dataParameter.Add(new DataParameter("@" + item.Condition, item.Content));
                }

        }
    return where;
}
</pre>
</code>
</div>
