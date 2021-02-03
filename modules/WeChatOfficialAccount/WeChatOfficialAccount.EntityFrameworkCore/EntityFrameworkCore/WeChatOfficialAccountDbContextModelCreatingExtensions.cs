﻿using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace WeChatOfficialAccount.EntityFrameworkCore
{
    public static class WeChatOfficialAccountDbContextModelCreatingExtensions
    {
        public static void ConfigureWeChatOfficialAccount(
            this ModelBuilder builder,
            Action<WeChatOfficialAccountModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new WeChatOfficialAccountModelBuilderConfigurationOptions(
                WeChatOfficialAccountDbProperties.DbTablePrefix,
                WeChatOfficialAccountDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */
        }
    }
}