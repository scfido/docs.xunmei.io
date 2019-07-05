# 简介

基于ABP vNext的文档库

## 创建文档项目

```sql
INSERT INTO `docs`.`DocsProjects`
(
    `Id`,
    `ExtraProperties`,
    `ConcurrencyStamp`,
    `Name`,
    `ShortName`,
    `Format`,
    `DefaultDocumentName`,
    `NavigationDocumentName`,
    `MinimumVersion`,
    `DocumentStoreType`,
    `MainWebsiteUrl`,
    `LatestVersionBranchName`
)
VALUES
(
    'c000eff1-9f0e-11e9-b61f-0242ac110002',
    '{\"GitHubRootUrl\":\"https://github.com/scfido/docs.xunmei.io/tree/{version}/docs/\",\"GitHubAccessToken\":\"******\"}',
    NULL,
    '白令海开发框架',
    'Bering',
    'md',
    'Index',
    'docs-nav.json',
    '0.0.1',
    'GitHub',
    '/',
    'master'
);
```
